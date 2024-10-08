using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleHospitalManagementSystem
{
    public enum Specializations { Cardiology, Neurology, Dermatology }
    public class Clinic :IDisplayInfo
    {
        //Attributes
        public int ClinicID { get;private set; }
        public string ClinicName { get;private set; }

        public Specializations Specialization;
        public List<Room> Rooms = new List<Room>();
        public Dictionary<Doctor,List<Appointment>> AvailableAppointments = new Dictionary<Doctor,List<Appointment>>();

        //Methods

        public Clinic(int id , string name, Specializations specializations)
        {
            ClinicID = id;
            ClinicName = name;
            Specialization = specializations;
            Console.WriteLine($"{name} Added to Hospital Management System");
        }
        //Adds rooms to the clinic.
        public void AddRoom (Room room)
        {
            if (room != null)
            {
                Rooms.Add(room);
                room.OccupyRoom();
            }
            else
                Console.WriteLine("Invalid input..");
        }

        // Generates appointment slots for the doctor on a specified day for a given period and adds them to the clinic.
        public void AddAvailableAppointment(Doctor doctor, DateTime appointmentDay, TimeSpan period)
        {
            TimeSpan start = new TimeSpan(9, 0, 0);
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                AvailableAppointments[doctor] = new List<Appointment>();
                for (int i = 0; i < period.TotalHours; i++)
                {
                    Appointment appointment = new Appointment();
                    appointment.ScheduleAppointment(null, appointmentDay, start.Add(new TimeSpan(i, 0, 0)),false);
                    AvailableAppointments[doctor].Add(appointment);
                    Console.WriteLine($"Appointment Scheduled for {doctor.Name} in {appointmentDay.AddHours(i).ToString("yyy-MM-dd")}  at {start.Add(new TimeSpan(i, 0, 0))}");
                }
            }
            else
            {
                Console.WriteLine($"{doctor.Name} Not Available to  Schedule Appointment in this Clinic");
            }
           
            Console.WriteLine("**************************************************");



        }

        public void BookAppointment (Patient patient, Doctor doctor, DateTime appointmentDay,TimeSpan appointmentTime)
        {
            Console.WriteLine("**************Book Appointment***********************");
            bool flage = false;
            if (AvailableAppointments.ContainsKey(doctor))
            {
                List<Appointment> appointments = AvailableAppointments[doctor];
                for (int i = 0; i < AvailableAppointments[doctor].Count; i++)
                {
                    if (doctor.patients.Contains(patient))
                    {
                        if (!appointments[i].IsBooked && appointments[i].AppointmentTime == appointmentTime && appointments[i].AppointmentDate == appointmentDay)
                        {
                            appointments[i].ScheduleAppointment(patient, appointmentDay, appointmentTime, true);
                            Console.WriteLine($"{patient.Name} Assigned appointment on {appointmentDay.ToString("yyy-MM-dd")} at {appointmentTime}");
                            flage = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This Patient Not Added to The Doctor ");
                    }
        
                }
                if (flage != true)
                    Console.WriteLine("Selected appointment is not available.");

            }
            else
            {
                Console.WriteLine("Doctor Not Found..");
            }
        }

        public void CancelAppointment(Patient patient,Doctor doctor, DateTime dateTime,TimeSpan time)
        {
            Console.WriteLine("**************Cancel Appointment***********************");
            if (AvailableAppointments.ContainsKey(doctor))
            {
                bool flage = false;
                List<Appointment> appointments = AvailableAppointments[doctor];
                for (int i = 0; i < AvailableAppointments[doctor].Count; i++)
                {
                    if (appointments[i].IsBooked && appointments[i].AppointmentTime == time && appointments[i].AppointmentDate == dateTime)
                    {
                        
                        appointments[i].CancelAppointment( patient, dateTime,  time);
                        doctor.patients.Remove(patient);
                        Console.WriteLine($"{patient.Name} Canced appointment on {appointments[i].AppointmentDate.ToString("yyy-MM-dd")} at {appointments[i].AppointmentTime}");
                        flage = true;
                    }
                }
                if (flage != true)
                    Console.WriteLine("Selected appointment is not available.");

            }
            else
            {
                Console.WriteLine("Doctor Not Found..");
            }

        }

       
        public void DisplayInfo()
        {
           
            Console.WriteLine("****************Display Available Appointments****************\n");
            foreach (var doctors in AvailableAppointments.Keys)
            {
                Console.WriteLine(doctors.Name);
                List<Appointment> appointments = AvailableAppointments[doctors];
                
                for (int i = 0; i < AvailableAppointments[doctors].Count; i++)
                {
                        appointments[i].DisplayInfo();

                }
                Console.WriteLine("**************************************************");
            }

        }










    }
}

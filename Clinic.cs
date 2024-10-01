using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Clinic
    {
        //Attributes
        public int ClinicID { get;private set; }
        public string ClinicName { get;private set; }
        public enum Specializations { Cardiology, Neurology, Dermatology }
        public Specializations Specialization;
        public List<Room> Rooms = new List<Room>();
        public Dictionary<Doctor,List<Appointment>> AvailableAppointments = new Dictionary<Doctor,List<Appointment>>();

        //Methods
        //Adds rooms to the clinic.
        public void AddRoom (Room room)
        {
            if (room != null)
                Rooms.Add(room);
            else
                Console.WriteLine("Invalid input..");
        }

        // Generates appointment slots for the doctor on a specified day for a given period and adds them to the clinic.
        public void AddAvailableAppointment(Doctor doctor, DateTime appointmentDay, TimeSpan period)
        {
            if (!AvailableAppointments.ContainsKey(doctor))
            {
                AvailableAppointments[doctor] = new List<Appointment>();
            }
            TimeSpan startHour = new TimeSpan(9,0,0);
            TimeSpan endHour = startHour + period;
            for (TimeSpan i = startHour; i <= endHour; i.Add(new TimeSpan(1,0,0)))
            {
                Appointment appointment = new Appointment();
                appointment.ScheduleAppointment(null, appointmentDay,i);
                AvailableAppointments[doctor].Add(appointment);
            }
            
        }

        public void BookAppointment (Patient patient, Doctor doctor, DateTime appointmentDay,TimeSpan appointmentTime)
        {
            bool flage = false;
            if (AvailableAppointments.ContainsKey(doctor))
            {
                List<Appointment> appointments = AvailableAppointments[doctor];
                for (int i = 0; i < AvailableAppointments[doctor].Count; i++)
                {
                    if (!appointments[i].IsBooked)
                    {
                        appointments[i].ScheduleAppointment(patient, appointmentDay, appointmentTime);
                        flage = true;
                    }
                }
                if(flage != true)
                    Console.WriteLine("Selected appointment is not available.");
            }
            else
            {
                Console.WriteLine("Doctor Not Found..");
            }
        }

        public void DisplayAvailableAppointments()
        {
            foreach (var doctors in AvailableAppointments.Keys)
            {
                Console.WriteLine(doctors.ToString());
                List<Appointment> appointments = AvailableAppointments[doctors];
                for (int i = 0; i < AvailableAppointments[doctors].Count; i++)
                {
                    appointments[i].DisplayAppointmentDetails();
                    
                }
                Console.WriteLine("**************************************************");
            }

        }










    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Appointment
    {
        //Attributes

        public Patient Patient;
        public Doctor Doctor;
        public DateTime AppointmentDate;

        //Constructor
        public Appointment(Patient patient, Doctor doctor, DateTime DT)
        { 
            Patient = patient;
            Doctor = doctor;
            AppointmentDate = DT;
        }

        //Methods
        //Schedules an appointment between a patient and a doctor.
        public void ScheduleAppointment (DateTime date)
        {
            if (AppointmentDate== date)
            {
                Patient.AssignedDoctor = Doctor;
                
            }
        }

        // Cancels the scheduled appointment
        public void CancelAppointment()
        {
            Doctor.patients.Remove(Patient);
        }

        //Displays appointment details.
        public void GetAppointmentDetails()
        {
            Console.WriteLine($"Appointment scheduled for {Patient} with {Doctor} on {AppointmentDate.ToString()}"); 
        }

    }
}

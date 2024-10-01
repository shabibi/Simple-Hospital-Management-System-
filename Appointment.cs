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

        public Patient Patient =null;
        public DateTime? AppointmentDate = null ;
        public TimeSpan? AppointmentTime = null;
        public bool IsBooked = false;

        //Methods
        //Schedules an appointment between a patient and a doctor.
        public void ScheduleAppointment (Patient patient, DateTime date,TimeSpan time)
        {
            Patient = patient;
            AppointmentDate = date.Date;
            AppointmentTime = time;
            IsBooked = true;
        }

        // Cancels the scheduled appointment
        
        public void CancelAppointment(out Patient patient, out DateTime? dateTime ,out TimeSpan? time)
        {
            patient =Patient;
            dateTime = AppointmentDate;
            time =  AppointmentTime;
            IsBooked = false;
        }

        //Displays appointment details.
        public void DisplayAppointmentDetails()
        {
            Console.WriteLine($"Appointment scheduled for {Patient.Name}  on {AppointmentDate.ToString()} at {AppointmentTime.ToString()} "); 
        }

    }
}

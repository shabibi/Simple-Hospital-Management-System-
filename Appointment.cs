using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleHospitalManagementSystem
{
    public class Appointment :IDisplayInfo, ISchedulable
    {
        //Attributes

        public Patient Patient =null;
        public DateTime AppointmentDate;
        public TimeSpan AppointmentTime;
        public bool IsBooked = false;

        //Methods
        //Schedules an appointment between a patient and a doctor.
       
        public void ScheduleAppointment (Patient patient, DateTime date,TimeSpan time,bool isbooked)
        {
                Patient = patient;
                AppointmentDate = date.Date;
                AppointmentTime = time;
                IsBooked = isbooked;
        }

        // Cancels the scheduled appointment

        public void CancelAppointment( Patient patient,  DateTime dateTime , TimeSpan time)
        {
            patient = null;
            AppointmentDate = dateTime;
            AppointmentTime = time;
            IsBooked = false;
        }

        //Displays appointment details.
        public void DisplayInfo()
        {
            if(IsBooked) 
            Console.WriteLine($"Appointment scheduled for {Patient.Name}  on {AppointmentDate.ToString()} at {AppointmentTime.ToString()} IsBooked: {IsBooked}"); 
            else 
                Console.WriteLine($"Appointment not scheduled  on {AppointmentDate.ToString()} at {AppointmentTime.ToString()} IsBooked {IsBooked}");
        }

    }
}

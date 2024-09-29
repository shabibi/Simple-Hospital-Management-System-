using System;
using System.Collections.Generic;
using System.Linq;
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

        public Appointment(Patient patient, Doctor doctor, DateTime DT)
        { 
            Patient = patient;
            Doctor = doctor;
            AppointmentDate = DT;
        }

    }
}

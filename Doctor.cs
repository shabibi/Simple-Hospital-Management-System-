using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Doctor : Person
    {
        //Attributes
        public int DoctorID { get;private set; }
        public string Specialization { get;private set; }
        public List<Patient> patients = new List<Patient>();

       //Constructor
        public Doctor(string name, int age, Gender gender, int doctorID, string specialization) : base(name, age, gender)
        {
            DoctorID = doctorID;
            Specialization = specialization;
        }
    }
}

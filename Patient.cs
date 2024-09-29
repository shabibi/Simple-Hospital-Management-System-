using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Patient : Person
    {
        public int Id { get;private set; }
        public string Ailment;
        public string AssignedDoctor;


        public Patient(string name, int age, Gender gender, string doctor):base(name,age,gender)
        { 
            AssignedDoctor = doctor;
        }

    }
}

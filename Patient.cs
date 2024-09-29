using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{

    public class Patient : Person
    {
        public int Id { get; private set; }
        public string Ailment;
        public Doctor AssignedDoctor; 
        public Room room; 


        public Patient(string name, int age, Gender gender, Doctor doctor) : base(name, age, gender)
        {
            AssignedDoctor = doctor;
        }

    }

}

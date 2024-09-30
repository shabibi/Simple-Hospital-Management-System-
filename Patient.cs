using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{

    public class Patient : Person
    {
        //Attributes
        public int Id { get; private set; }
        public string Ailment;
        public Doctor AssignedDoctor; 
        public Room room;

        //Constructor: Initialize attributes and assign a doctor.
        public Patient(string name, int age, Gender gender,string ailment, Doctor doctor) : base(name, age, gender)
        {
            Ailment = ailment;
            AssignedDoctor = doctor;
        }

        //Methods

        //Override the DisplayInfo() method to include PatientID and Ailment.
        public override void DisplayInfo()
        {
            Console.WriteLine($"PatientID : {Id}, Ailment : {Ailment}, Doctor : {Ailment}");
            
        }



    }

}

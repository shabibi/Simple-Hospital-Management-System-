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
        public int Id;
        public string Ailment;
        

        //Constructor: Initialize attributes and assign a doctor.
        public Patient(int  id ,string name, int age, Gender gender,string ailment) : base(name, age, gender)
        {
            Id = id;
            Ailment = ailment;
            
        }

        //Override the DisplayInfo() method to include PatientID and Ailment.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"PatientID : {Id}, Ailment : {Ailment}");
            
        }



    }

}

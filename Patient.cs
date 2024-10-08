using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{

    public class Patient : Person, IPatientCare
    {
        //Attributes
        public int Id;
        public string Ailment;
        public Nurse nurse;
        public Dictionary<string, string> VitalSigns = new Dictionary<string, string>();
        public List<string> MedicationHistory = new List<string>();
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

        public void ProvidingCare()
        {
            nurse.CheckVitals(this);
            Console.WriteLine("Enter medication to administer:");
            string medication = Console.ReadLine();
            nurse.AdministerMedication(this, medication);

        }

    }

}

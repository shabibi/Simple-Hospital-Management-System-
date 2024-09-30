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

        //Methods

        // Adds a patient to the doctor’s list.
        public void AddPatient(Patient patient)
        {
            bool flag = false;
            if (patient != null)
            {
                for (int i = 0; i < patients.Count; i++)
                {
                    if (patients[i] == patient)
                    {
                        flag = true;
                    }
                }
                if (flag != true)
                {
                    patients.Add(patient);
                }
                else
                    Console.WriteLine("This Patient Added before");
            }
        }

        //Removes a patient from the doctor’s list.
        public void RemovePatient(Patient patient)
        {
            bool flag = false;
            if (patient != null)
            {
                for (int i = 0; i < patients.Count; i++)
                {
                    if (patients[i] == patient)
                    {
                        patients.RemoveAt(i);
                        flag = true;
                        return;
                    }
                }
                if (flag != true)
                {
                    Console.WriteLine("This Patient Not Assigned ");
                }
            }
        }

        //Override the DisplayInfo() method to include DoctorID and Specialization
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"DoctorID : {DoctorID}, Specialization : {Specialization}");
        }

    }
}

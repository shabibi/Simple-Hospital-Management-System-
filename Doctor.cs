using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Doctor : Person ,IDisplayInfo
    {
        //Attributes
        public int DoctorID { get;private set; }
        public Specializations Specializations;
        public List<Patient> patients = new List<Patient>();
        public List<Clinic> AssignedClinics = new List<Clinic>();

       //Constructor
        public Doctor(int doctorID, string name, int age, Gender gender,  Specializations specializations) : base(name, age, gender)
        {
            DoctorID = doctorID;
            this.Specializations = specializations;
        }

        //Methods
        // Adds a patient to the doctor’s list.
        public void AddPatient(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
            }
            else
                Console.WriteLine("This Patient Added before");
        }

        //Removes a patient from the doctor’s list.
        public void RemovePatient(Patient patient)
        {
            bool flag = false;
            if (patient != null)
            {
                if (patients.Contains(patient))
                {
                    patients.Remove(patient);
                }
                else
                {
                    Console.WriteLine("This Patient Not Assigned ");
                }
            }
        }

        //Override the DisplayInfo() method to include DoctorID and Specialization
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"DoctorID : {DoctorID}, Specialization : {Specializations}");
        }

        public void AssignToClinic(Clinic clinic, DateTime day, TimeSpan period)
        {
            if (!AssignedClinics.Contains(clinic))
            {
                if (Specializations == clinic.Specialization)
                {
                    clinic.AddAvailableAppointment(this, day, period);
                    AssignedClinics.Add(clinic);
                }
                else
                    Console.WriteLine("Doctor's Specialization Diffrent than clinic");


            }
            else
                Console.WriteLine("This Clinic Assigned befor..");
        }
        public void DisplayAssignedClinics()
        {
            Console.WriteLine("***************Display Assigned Clinics***************\n");
            if (AssignedClinics.Count > 0)
            {
                Console.WriteLine($"{Name} Assigned in :");
                for (int i = 0; i < AssignedClinics.Count; i++)
                {
                    Console.WriteLine(AssignedClinics[i].ClinicName);

                }
            }
            else 
                Console.WriteLine("Not assigned in any clinic");
            Console.WriteLine("*****************************************");
            
        }

    }
}

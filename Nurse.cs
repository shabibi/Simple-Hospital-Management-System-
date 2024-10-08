using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Nurse :Person , IDisplayInfo
    {
        //Attributes
        public int NurseID;
        public Clinic AssignedClinic;
        public Specializations Specialization;
        public List<Patient> AssignedPatients = new List<Patient>();
        
        //Constructor
        public Nurse (int NurseID,string name, int age, Gender gender, Clinic AssignedClinic, Specializations Specialization) :base(name,age,gender)
        {
            this.NurseID = NurseID;
            this.AssignedClinic = AssignedClinic;
            this.Specialization = Specialization;

        }
        // Displays the nurse’s information, such as name, specialization, and assigned clinic.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"DoctorID : {NurseID}, Specialization : {Specialization}, Clinic : {AssignedClinic.ClinicName}");
        }

        // assisting doctors with specific patients during appointments or treatments.

        public void AssistDoctor (Doctor doctor, Patient patient)
        {
            if (doctor.Specializations == this.Specialization)
            {
                doctor.AddPatient(patient);
                AssignedPatients.Add(patient);
                Console.WriteLine($"{patient.Name} Added to {doctor.Name}" );
            }
            else
            {
                Console.WriteLine("The Doctor and Nurse Not in same Clinic..\n");
            }
        }

        // Allows the nurse to check and record vital signs for a specific patient.
        public void CheckVitals(Patient patient)
        {
            Console.WriteLine($"Checking vitals for {patient.Name} ");
            List<string> vitals = new List<string>{ "Heart Rate", "Blood Pressure", "Temperature", "Respiratory Rate" };
            string value = null;
            Console.WriteLine("Enter the Vlues of :");
            for (int i = 0; i < vitals.Count; i++)
            {
                Console.WriteLine(vitals[i]);
                value = Console.ReadLine();
                patient.VitalSigns.Add(vitals[i],value);

            }
            Console.WriteLine($"vitals value Added to {patient.Name} file ");
        }

        // Manages the administration of prescribed medication to patients.
        public void AdministerMedication(Patient patient, string medication)
        {
            Console.WriteLine($"Nurse {Name} is administering {medication} to {patient.Name}\n ");
            patient.MedicationHistory.Add(medication);
            Console.WriteLine($"{medication} has been successfully administered to {patient.Name}.\n");

        }
    }
}

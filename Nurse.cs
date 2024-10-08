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
    }
}

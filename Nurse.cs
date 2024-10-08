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
        public List <Doctor> doctors = new List<Doctor>();
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
            Console.WriteLine($"DoctorID : {NurseID}, Specialization : {Specialization}, Clinic : {AssignedClinic}");
        }



    }
}

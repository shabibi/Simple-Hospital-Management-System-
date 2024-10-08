using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Nurse :Person
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


    }
}

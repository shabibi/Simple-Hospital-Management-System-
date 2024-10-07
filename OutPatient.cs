using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class OutPatient : Patient 
    {
        public Clinic ClinicAssigned;

        public OutPatient(int id, string name, int age, Gender gender, string ailment, Clinic ClinicAssigned) : base(id, name, age, gender, ailment)
        {
            Console.WriteLine("****************Add New Out Patient****************\n");
            this.ClinicAssigned = ClinicAssigned;
            Console.WriteLine($"\nPatient {name} added to {ClinicAssigned.ClinicName}");
            Console.WriteLine("\n**************************************************");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doctor :{ClinicAssigned.ClinicName }");
        }
    }
}

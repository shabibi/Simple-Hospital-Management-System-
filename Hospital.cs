using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Hospital
    {
        //Attributes
        public List<Doctor> DoctorsList = new List<Doctor>();
        public List<Patient> PatientsList = new List<Patient>();
        public List<Room> RoomsList = new List<Room>();

        //Constructor
        public Hospital(List<Doctor> doctors, List<Patient>patients,List<Room>room) 
        { 
            DoctorsList = doctors;
            PatientsList = patients;
            RoomsList = room;
        }



    }
}

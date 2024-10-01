using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class Clinic
    {
        //Attributes
        public int ClinicID { get;private set; }
        public string ClinicName { get;private set; }
        public enum Specializations { Cardiology, Neurology, Dermatology }
        public Specializations Specialization;
        public List<Room> Rooms = new List<Room>();
        public Dictionary<Doctor,List<Appointment>> AvailableAppointments = new Dictionary<Doctor,List<Appointment>>();






    }
}

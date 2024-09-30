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

        //Methods

        //Adds a new doctor.
        public void AddDoctor(Doctor doctor)
        {
            if (DoctorsList.Contains(doctor))
                DoctorsList.Add(doctor);
            else
                Console.WriteLine("Tis Doctore is Added befor.. ");

        }

        public void AddPatient(Patient patient)
        {
            if(!PatientsList.Contains(patient))
                PatientsList.Add(patient);
            else
                Console.WriteLine("Tis patient is Added befor.. ");
        }

        //Assigns a room to a patient
        public void AssignRoomToPatient(Patient patient, Room room)
        {
            if (RoomsList.Contains(room))
            {
                if (room.OccupyRoom())
                {
                    Console.WriteLine("This Room is Occupied");
                }
                else
                {
                    if (patient.room != room)
                    {
                        room.OccupyRoom();
                        patient.AssignRoom(room);
                    }
                }
            }
        }

        //: Displays all patients assigned to a specific doctor
        public void GetDoctorPatients(Doctor doctor)
        {
            for (int i = 0; i < DoctorsList.Count; i++)
            {
                if (DoctorsList[i] == doctor)
                {
                    for(int j = 0; j < doctor.patients.Count; j++)
                        Console.WriteLine(doctor.patients[i]);
                }
            }
        }
    }
}

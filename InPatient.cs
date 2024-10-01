using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public class InPatient : Patient
    {
        public Doctor AssignedDoctor;
        public Room room;
        public DateTime AdmissionDate;

        public InPatient (int id, string name, int age, Gender gender, string ailment, Doctor assignedDoctor, Room room, DateTime AdmissionDate) : base(id,name,age,gender,ailment)
        {
            this.AssignedDoctor = assignedDoctor;
            this.room = room;
            this.AdmissionDate = AdmissionDate;
        }

        //Methods
        //AssignRoom(Room room): Assigns a room to the patient.
        public void AssignRoom(Room room)
        {
            if (!room.VacateRoom())
            {
                room.OccupyRoom();
                this.room = room;

                Console.WriteLine($"{Name}  assigned to room {room.RoomNumber}");
            }
            else
            {
                Console.WriteLine("Room not availble.");
            }
        }

        // Marks the patient as discharged (set the room to null).
        public void Discharge()
        {
            room.VacateRoom();
            room = null;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doctor : {AssignedDoctor}, Room : {room.RoomNumber}, AdmissionDate: {AdmissionDate.ToString()}");

        }
    }
}

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
        public Room room ;
        public DateTime AdmissionDate;

        public InPatient(int id, string name, int age, Gender gender, string ailment, Doctor assignedDoctor, DateTime AdmissionDate) : base(id, name, age, gender, ailment)
        {
            Console.WriteLine("****************Add New In Patient****************\n");
            this.AssignedDoctor = assignedDoctor;

            this.AdmissionDate = AdmissionDate;
            Console.WriteLine($"\nPatient {name} Added to Hospital System as InPatient");
            Console.WriteLine("\n**************************************************");
        }

        //Methods
        //AssignRoom(Room room): Assigns a room to the patient.
        public void AssignRoom(Room room)
        {
            Console.WriteLine("****************Assign Room****************\n");
            if (!room.VacateRoom())
            {
                    this.room = room;
                  Console.WriteLine($"{Name}  assigned to room {room.RoomNumber}");

            }
            else
            {
                Console.WriteLine("Room not availble.");
            }
            Console.WriteLine("\n**************************************************");
        }

        // Marks the patient as discharged (set the room to null).
        public void Discharge()
        {
            Console.WriteLine("****************Discharge****************\n");
            if(!room.VacateRoom())
            {
                Console.WriteLine($"{Name}  Discharged from room {room.RoomNumber}");
                room = null;
            }
            else
                Console.WriteLine("Room is  Empty.");



        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Doctor : {AssignedDoctor}, Room : {room.RoomNumber}, AdmissionDate: {AdmissionDate.ToString()}");

        }
    }
}

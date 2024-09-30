using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{

    public class Patient : Person
    {
        //Attributes
        public int Id { get; private set; }
        public string Ailment;
        public Doctor AssignedDoctor; 
        public Room room;

        //Constructor: Initialize attributes and assign a doctor.
        public Patient(int  id ,string name, int age, Gender gender,string ailment, Doctor doctor) : base(name, age, gender)
        {
            Id = id;
            Ailment = ailment;
            AssignedDoctor = doctor;
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

        //Override the DisplayInfo() method to include PatientID and Ailment.
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"PatientID : {Id}, Ailment : {Ailment}, Doctor : {AssignedDoctor.Name}");
            
        }



    }

}

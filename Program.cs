﻿using static SimpleHospitalManagementSystem.Person;
using static SimpleHospitalManagementSystem.Room;

namespace SimpleHospitalManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Test Case 1: Create doctors and patients
            Console.WriteLine("===== Test Case 1: Create Doctors and Patients =====");
            Doctor doctor1 = new Doctor(1, "Dr. Smith", 45, Gender.Male, "Cardiology");
            Doctor doctor2 = new Doctor(2, "Dr. Brown", 38, Gender.Female, "Neurology");
            Patient patient1 = new Patient(101, "John Doe", 30, Gender.Male, "Heart Disease", doctor1);
            Patient patient2 = new Patient(102, "Jane Roe", 28, Gender.Female, "Migraine", doctor2);
            // Display information
            patient1.DisplayInfo();
            patient2.DisplayInfo();
            doctor1.DisplayInfo();
            doctor2.DisplayInfo();
            // Test Case 2: Assign rooms to patients
            Console.WriteLine("\n===== Test Case 2: Room Assignment =====");
            Room room1 = new Room(202, RoomTypes.ICU);
            Room room2 = new Room(203, RoomTypes.General);
            patient1.AssignRoom(room1);
            patient2.AssignRoom(room2);
            // Display room details
            Console.WriteLine($"Room {room1.RoomNumber} is occupied: {room1.IsOccupied}");
            Console.WriteLine($"Room {room2.RoomNumber} is occupied: {room2.IsOccupied}");

            // Test Case 3: Schedule appointments
            Console.WriteLine("\n===== Test Case 3: Schedule Appointments =====");
            Appointment appointment1 = new Appointment(patient1, doctor1, new DateTime(2024, 10,
           5, 9, 30, 0));
            appointment1.ScheduleAppointment(new DateTime(2024, 10, 5, 9, 30, 0));
            appointment1.GetAppointmentDetails();
            Appointment appointment2 = new Appointment(patient2, doctor2, new DateTime(2024, 10,
           6, 11, 0, 0));
            appointment2.ScheduleAppointment(new DateTime(2024, 10, 6, 11, 0, 0));
            appointment2.GetAppointmentDetails();

            // Test Case 4: Discharge patients
            Console.WriteLine("\n===== Test Case 4: Discharge Patients =====");
            patient1.Discharge();
            Console.WriteLine($"Patient {patient1.Name} has been discharged. Room { room1.RoomNumber} is now occupied: { room1.IsOccupied}");

            // Test Case 5: Display doctor-patient details
             Console.WriteLine("\n===== Test Case 5: Display Doctor-Patient Details =====");
            doctor1.DisplayInfo();
            doctor2.DisplayInfo();
        }
    }
}

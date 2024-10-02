using static SimpleHospitalManagementSystem.Clinic;
using static SimpleHospitalManagementSystem.Doctor;
using static SimpleHospitalManagementSystem.Person;
using static SimpleHospitalManagementSystem.Room;

namespace SimpleHospitalManagementSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create doctors
            Doctor doctor1 = new Doctor(1, "Dr. John Smith", 45, Gender.Male, Specializations.Cardiology);
            Doctor doctor2 = new Doctor(2, "Dr. Alice Brown", 38, Gender.Female, Specializations.Neurology);
            Console.WriteLine();
            // Create clinics
            Clinic cardiologyClinic = new Clinic(1, "Cardiology Clinic", Specializations.Cardiology);
            Clinic neurologyClinic = new Clinic(2, "Neurology Clinic", Specializations.Neurology);
            Console.WriteLine();
            // Assign doctors to clinics and generate appointment slots (9 AM - 12 PM)
            doctor1.AssignToClinic(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(3)); // Expected: Appointments generated for 9 AM, 10 AM, 11 AM
            doctor2.AssignToClinic(neurologyClinic, new DateTime(2024, 10, 6), TimeSpan.FromHours(3));  // Expected: Appointments generated for 9 AM, 10 AM, 11 AM
            Console.WriteLine();
            doctor1.DisplayAssignedClinics(); // Expected: Cardiology Clinic is displayed
            doctor2.DisplayAssignedClinics();                                  // Create rooms for clinics
            Console.WriteLine();
            Room room1 = new Room(101, RoomTypes.IPR);  // Room for in-patients
            Room room2 = new Room(102, RoomTypes.OPR);  // Room for out-patients
          
            cardiologyClinic.AddRoom(room1); // Expected: Room 101 added to Cardiology Clinic
            neurologyClinic.AddRoom(room2);  // Expected: Room 102 added to Neurology Clinic
            Console.WriteLine();                         // Create patients
            InPatient inpatient1 = new InPatient(101, "Jane Doe", 30, Gender.Female, "Cardiac Arrest", doctor1, DateTime.Now);
            Console.WriteLine();

            inpatient1.AssignRoom(room1);
            Console.WriteLine();
            OutPatient outpatient1 = new OutPatient(102, "Mark Doe", 28, Gender.Male, "Migraine", neurologyClinic);

            // Assign room to in-patient
            //inpatient1.AssignRoom(room1); 
            // Expected: Room 101 becomes occupied
            // Book an appointment for out-patient in Cardiology Clinic
            Console.WriteLine();
            cardiologyClinic.DisplayAvailableAppointments();
            Console.WriteLine();
            cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10)); // Expected: Appointment at 10 AM booked
                                                                                                                       // View doctor's assigned clinics
            Console.WriteLine();
            //View available appointments in Cardiology Clinic
            cardiologyClinic.DisplayAvailableAppointments();// Expected: Show available slots for Dr. John Smith at 9 AM, 11 AM (10 AM is booked)
            Console.WriteLine();
            // Discharge in-patient

            inpatient1.Discharge();
            // Expected: Room 101 becomes available, patient discharged
            // Book another appointment for the same out-patient in Cardiology Clinic
            Console.WriteLine();
            cardiologyClinic.BookAppointment(outpatient1,doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(11)); // Expected: Appointment at 11 AM booked
            // Try booking a time outside available slots
            Console.WriteLine();
            cardiologyClinic.BookAppointment(outpatient1,doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(12));
            // Expected: No available appointments for this time
            // Cancel an appointment
            Console.WriteLine();
            cardiologyClinic.DisplayAvailableAppointments();
            Console.WriteLine();
            cardiologyClinic.CancelAppointment(outpatient1,doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10));
            Console.WriteLine();
            cardiologyClinic.DisplayAvailableAppointments();
            // Expected: Appointment cancellation message for 10 AM
            // View available appointments after booking and cancellation
           
            // Expected: 10 AM slot available again, 9 AM and 11 AM booked
        }
    }

    }


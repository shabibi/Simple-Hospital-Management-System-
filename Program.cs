using System.Diagnostics;
using static SimpleHospitalManagementSystem.Clinic;
using static SimpleHospitalManagementSystem.Doctor;
using static SimpleHospitalManagementSystem.Person;
using static SimpleHospitalManagementSystem.Room;

namespace SimpleHospitalManagementSystem
{
    internal class Program
    {
        static Doctor doctor1;
        static Doctor doctor2;
        static Clinic cardiologyClinic;
        static Clinic neurologyClinic;
        static Room room1;
        static Room room2;
        static InPatient inpatient1;
        static OutPatient outpatient1;
        static Nurse nurse1;

        public static void Main(string[] args)
        {
            
            bool flge = false;
            Console.WriteLine("*******************Simple Hospital Management System*********************\n");
            Console.WriteLine("_____________________________________________________________\n");


            do
            {
                Console.Clear();
                Console.WriteLine("Enter Number of your Choise..\n ");
                Console.WriteLine(" 1. Add Doctors\n");
                Console.WriteLine(" 2. Add Clinic\n");
                Console.WriteLine(" 3. Assign doctors to clinics\n");
                Console.WriteLine(" 4. Create rooms for clinics\n");
                Console.WriteLine(" 5. Add Nurse\n");
                Console.WriteLine(" 6. Add patients\n");
                Console.WriteLine(" 7. Assign Room to patient\n");
                Console.WriteLine(" 8. Display Available Appointments\n");
                Console.WriteLine(" 9. Book Appointment\n");
                Console.WriteLine(" 10. Discharge in-patient\n");
                Console.WriteLine(" 11. Cancel Appointment\n");
                Console.WriteLine(" 12. Exit\n");

                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        //Create doctors
                        Console.Clear();
                        doctor1 = new Doctor(1, "Dr. John Smith", 45, Gender.Male, Specializations.Cardiology);
                        doctor2 = new Doctor(2, "Dr. Alice Brown", 38, Gender.Female, Specializations.Neurology);
                        doctor1.DisplayInfo();
                        Console.WriteLine();
                        doctor2.DisplayInfo();

                        break;

                    case 2:
                        // Create clinics
                        Console.Clear();
                        cardiologyClinic = new Clinic(1, "Cardiology Clinic", Specializations.Cardiology);
                        Console.WriteLine();
                        neurologyClinic = new Clinic(2, "Neurology Clinic", Specializations.Neurology);
                        break;

                    case 3:
                        // Assign doctors to clinics and generate appointment slots (9 AM - 12 PM)
                        Console.Clear();
                        doctor1.AssignToClinic(cardiologyClinic, new DateTime(2024, 10, 5), TimeSpan.FromHours(3));
                        doctor2.AssignToClinic(neurologyClinic, new DateTime(2024, 10, 6), TimeSpan.FromHours(3));
                        doctor1.DisplayAssignedClinics(); 
                        doctor2.DisplayAssignedClinics();
                        break;

                    case 4:
                        Console.Clear();
                        room1 = new Room(101, RoomTypes.IPR);  // Room for in-patients
                        room1.DisplayInfo();
                        room2 = new Room(102, RoomTypes.OPR);  // Room for out-patients
                        room2.DisplayInfo();
                        break;
                    case 5:
                        nurse1 = new(111, "Sam", 23, Gender.Female, cardiologyClinic, Specializations.Cardiology);
                        nurse1.DisplayInfo();
                        nurse1.AssistDoctor(doctor1, outpatient1);
                        Console.WriteLine();
                        break;

                    case 6:
                        // Create patients
                        Console.Clear();
                        inpatient1 = new InPatient(101, "Jane Doe", 30, Gender.Female, "Cardiac Arrest", doctor1, DateTime.Now);
                        outpatient1 = new OutPatient(102, "Mark Doe", 28, Gender.Male, "Migraine", neurologyClinic);
                       

                        break;

                    case 7:
                        // Assign room to in-patient
                        Console.Clear();
                        cardiologyClinic.AddRoom(room1); // Expected: Room 101 added to Cardiology Clinic
                        neurologyClinic.AddRoom(room2);  // Expected: Room 102 added to Neurology Clinic
                        // Expected: Room 101 becomes occupied
                        inpatient1.AssignRoom(room1);
                        break;

                    case 8:
                        Console.Clear();
                        cardiologyClinic.DisplayInfo();
                        break;

                    case 9:
                        Console.Clear();
                        // Book an appointment for out-patient in Cardiology Clinic
                        // Expected: Appointment at 10 AM booked
                        cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10));
                        cardiologyClinic.DisplayInfo();
                        // Book another appointment for the same out-patient in Cardiology Clinic

                        // Expected: Appointment at 11 AM booked
                        Console.WriteLine();
                        cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(11));
                        cardiologyClinic.DisplayInfo();
                        // Try booking a time outside available slots
                        Console.WriteLine();
                        cardiologyClinic.BookAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(12));
                        break;

                    case 10:
                        Console.Clear();
                        // Discharge in-patient
                        // Expected: Room 101 becomes available, patient discharged
                        inpatient1.Discharge();
                        room1.DisplayInfo();

                        break;

                    case 11:
                        // Cancel an appointment
                        Console.WriteLine();
                        cardiologyClinic.DisplayInfo();
                        Console.WriteLine();
                        cardiologyClinic.CancelAppointment(outpatient1, doctor1, new DateTime(2024, 10, 5), TimeSpan.FromHours(10));
                        cardiologyClinic.DisplayInfo();

                        break;

                    case 12:
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid Input..");
                        break;


                }
                Console.WriteLine("Enter 1 to Display Menu..");
                string count = Console.ReadLine();

                if (count == "1")
                {
                    flge = true;
                }
                else
                    flge = false;

            } while (flge == true);
            
        }

        
    }

    }


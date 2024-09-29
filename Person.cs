using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHospitalManagementSystem
{
    public abstract class Person
    {
        // Attributes:

        public string Name { get;private set; }
        public int Age { get;private set; }   
        public string Gender { get;private set; }

        //Constructor
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        //Method: print the person’s details.

        public void DisplayInfo() 
        {
            if (Name == null)
            {
                Console.WriteLine("Person Not Found");
                return;
            }
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Age    : {Age}");
            Console.WriteLine($"Gender : {Gender}");
        }

    }
}

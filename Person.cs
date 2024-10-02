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

        public string Name;
        public int Age;
        public Gender gender;
        public enum Gender { Male, Female }

        //Constructor
        public Person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            this.gender = gender;
        }

        //Method: print the person’s details.

        public virtual void DisplayInfo() 
        {
            if (Name == null)
            {
                Console.WriteLine("Person Not Found");
                return;
            }
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender : {gender}");
            
        }



    }
}

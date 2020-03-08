using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {

            Console.WriteLine(this.GetFullName() + " is " + this.Age + " years old.");
        }
        public void  GetPerson(string Choice)
        {
            Console.Write("\nPlease Enter Your "+ Choice + "'s First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Please Enter Your " + Choice + "'s  Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Please Enter Your " + Choice + "'s  Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("\nPlease Enter " + FirstName + "'s " + "Spouse's First Name: ");
            Spouse.FirstName = Console.ReadLine();

            Spouse.LastName = LastName;

            Console.Write("Please Enter " + Spouse.FirstName + "'s " + "Age: ");
            Spouse.Age = int.Parse(Console.ReadLine());

            
        }
    }
}

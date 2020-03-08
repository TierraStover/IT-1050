using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tPlease Enter The Names Of Two Couples You Know or Admire\n\t\t(Ex: Yourself, Relatives or Celebrities)");

            #region Code for Couple One

            Person p1 = new Person();
            p1.Spouse = new Person();

            Console.WriteLine("\n\t\t\t[Couple One's Information]");

            p1.GetPerson("First Choice");

            p1.Spouse.Spouse = p1;

            #endregion

            #region  Code For Couple Two

            Person p2 = new Person();
            p2.Spouse = new Person();

            Console.WriteLine("\n\t\t\t[Couple Two's Information]");

            p2.GetPerson("Second Choice");

            p2.Spouse.Spouse = p2;

            #endregion

            #region Code For Couples' Goals Results 

            Console.WriteLine("\n\t\t\t[Couples' Goals Results]\n");
            
            p1.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();

            Person.SumOfAllAges += p1.Age;
            Person.SumOfAllAges += p1.Spouse.Age;
            Person.SumOfAllAges += p2.Age;
            Person.SumOfAllAges += p2.Spouse.Age;
            Person.SumOfAllAges /= 4;

            Console.WriteLine("\n\tThe Average Age of " + p1.FirstName + ", " + p1.Spouse.FirstName + ", " + p2.FirstName + " and " + p2.Spouse.FirstName + " is " + Person.SumOfAllAges + ".");
            #endregion

            Console.WriteLine("\n\t\t\tPress Any Key To Close This Window");
            Console.ReadKey();
        }
    }
}



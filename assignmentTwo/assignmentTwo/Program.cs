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
            #region Code for Couple One
           
            Console.WriteLine("\tPlease Enter The Names Of Two Couples You Know or Admire\n\t\t(Ex: Yourself, Relatives or Celebrities)");
            Console.WriteLine("\n\t\t\t[Couple One's Information]");
            Person p1 = new Person();
            p1.Spouse = new Person();
            
            Console.Write("\nPlease Enter Your First Choice's First Name: ");
            p1.FirstName = Console.ReadLine();

            Console.Write("Please Enter Your First Choice's Last Name: ");
            p1.LastName = Console.ReadLine();
            
            Console.Write("Please Enter Your First Choice's Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.Write("\nPlease Enter " + p1.FirstName + "'s " + "Spouse's First Name: ");
            p1.Spouse.FirstName = Console.ReadLine();

            p1.Spouse.LastName = p1.LastName;
            
            Console.Write("Please Enter " + p1.Spouse.FirstName + "'s " + "Age: ");
            p1.Spouse.Age = int.Parse(Console.ReadLine());

            p1.Spouse.Spouse = p1;
            #endregion

            #region  Code For Couple Two
            Person p2 = new Person();
            p2.Spouse = new Person();

            Console.WriteLine("\n\t\t\t[Couple Two's Information]");
            Console.Write("\nPlease Enter Your Second Choice's First Name: ");
            p2.FirstName = Console.ReadLine();

            Console.Write("Please Enter Your Second Choice's Last Name: ");
            p2.LastName = Console.ReadLine();

            Console.Write("Please Enter Your Second Choice's Age: ");
            p2.Age = int.Parse(Console.ReadLine());

            Console.Write("\nPlease Enter " + p2.FirstName + "'s " + "Spouse's First Name: ");
            p2.Spouse.FirstName = Console.ReadLine();

            p2.Spouse.LastName = p2.LastName;

            Console.Write("Please Enter " + p2.Spouse.FirstName + "'s " + " Age: ");
            p2.Spouse.Age = int.Parse(Console.ReadLine());
            p2.Spouse.Spouse = p2;
            #endregion


            #region Code For Couples' Goals Results 
           Person.SumOfAllAges = 0;
           Console.WriteLine("\n\t\t\t[Couples' Goals Results]\n");
           p1.PrintNameAndAge();
           p1.Spouse.PrintNameAndAge();
           p2.PrintNameAndAge();
           p2.Spouse.PrintNameAndAge();

           Person.SumOfAllAges += p1.Age;
           Person.SumOfAllAges += p1.Spouse.Age;
           Person.SumOfAllAges += p2.Age;
           Person.SumOfAllAges += p2.Spouse.Age;
           Person.SumOfAllAges/=4;

           Console.WriteLine("\n\tThe Average Age of " + p1.FirstName + ", " + p1.Spouse.FirstName +", " + p2.FirstName + " and " + p2.Spouse.FirstName + " is "  + Person.SumOfAllAges + ".");
           
           Console.WriteLine("\n\t\t\tPress Any Key To Close This Window");
           Console.ReadKey();
            #endregion
        }
    }
    
}

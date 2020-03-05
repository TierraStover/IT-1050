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
            #region Code for P1
            Person p1 = new Person();
            p1.Spouse = new Person();
            
            Console.Write("Please Enter Your First Name: ");
            p1.FirstName = Console.ReadLine();

            Console.Write("Please Enter Your Last Name: ");
            p1.LastName = Console.ReadLine();
            
            Console.Write("Please Enter Your Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.Write("Please Enter " + p1.FirstName + "'s " + "Spouse's First Name: ");
            p1.Spouse.FirstName = Console.ReadLine();

            p1.Spouse.LastName = p1.LastName;
            
            Console.Write("Please Enter" + p1.Spouse.FirstName + "'s " + "Age: ");
            p1.Spouse.Age = int.Parse(Console.ReadLine());

            p1.Spouse.Spouse = p1;
            #endregion

            #region  Code For P2
            Person p2 = new Person();
            p2.Spouse = new Person();

            Console.Write("Please Enter Your First Name: ");
            p2.FirstName = Console.ReadLine();

            Console.Write("Please Enter Your Last Name:");
            p2.LastName = Console.ReadLine();

            Console.Write("Please Enter Your Age:");
            p2.Age = int.Parse(Console.ReadLine());

            Console.Write("Please Enter " + p2.FirstName + "'s " + "Spouse's First Name: ");
            p2.Spouse.FirstName = Console.ReadLine();

            p2.Spouse.LastName = p2.LastName;

            Console.Write("Please Enter" + p2.Spouse.FirstName + "'s " + "Age: ");
            p2.Spouse.Age = int.Parse(Console.ReadLine());
            p2.Spouse.Spouse = p2;
            #endregion

            
        }
    }
}

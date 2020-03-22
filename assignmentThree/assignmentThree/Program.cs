using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentThree
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instructor Code Section

            Instructor John = new Instructor("John Glenn", "English");

            Instructor Mike = new Instructor("Mike Tyson", "Math");


            #endregion

            #region Student Code Section

            Student Jane = new Student(John, "Jane Austen", 0);

            Student Joe = new Student(John, "Joe Pesci", 0);

            Student Melissa = new Student(Mike,"Melissa McCarthy", 0);

            Student Matt = new Student(Mike,"Matt Damon", 0);

            
            #endregion

            #region Print Section
           
            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.SetGrade(95);
            Joe.SetGrade(85);
            Melissa.SetGrade(90);
            Matt.SetGrade(92);

            Console.WriteLine("\n\t\t   [Courses Offerings]");
            Console.Write(John.GetInstructor());
            Console.WriteLine("\n" + Mike.GetInstructor());

            Console.WriteLine("\n\t\t\t  [Enrolled Students]");
            Console.WriteLine(Jane.GetStudent());
            Console.WriteLine(Joe.GetStudent());
            Console.WriteLine(Melissa.GetStudent());
            Console.WriteLine(Matt.GetStudent());

            #endregion

            Console.WriteLine("\n\t\tPress Any Key To Close This Window");
            Console.ReadKey();
        }
    }
}

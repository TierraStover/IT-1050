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
            Console.WriteLine("\n[Courses Offerings]");
            Console.WriteLine(John.GetInstructor());
            Console.WriteLine(Mike.GetInstructor());

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.SetGrade(95);
            Joe.SetGrade(85);
            Melissa.SetGrade(90);
            Matt.SetGrade(92);
         
            Console.WriteLine("\n[Enrolled Students]");
            Console.WriteLine(Jane.GetStudent() + John.GetInstructor());
            Console.WriteLine(Joe.GetStudent() + John.GetInstructor());
            Console.WriteLine(Melissa.GetStudent() + Mike.GetInstructor());
            Console.WriteLine(Matt.GetStudent() + Mike.GetInstructor());


            #endregion


            Console.ReadKey();
        }
    }
}

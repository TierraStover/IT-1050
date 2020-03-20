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
            
            Instructor John = new Instructor("John", "English");

            Instructor Mike = new Instructor("Mike", "Math");

           
            #endregion

            #region Student Code Section
            
            Student Jane = new Student("Jane", 0, John);

            Student Joe = new Student("Joe",0,John);

            Student Melissa = new Student("Melissa", 0, Mike);
            
            Student Matt= new Student("Matt", 0, Mike);

            #endregion

            #region Print Section
            John.GetInstructor();
            Mike.GetInstructor();

            John.SetStudentGrade("Jane", 95);
            John.SetStudentGrade("Joe", 85);
            Mike.SetStudentGrade("Melissa", 90);
            Mike.SetStudentGrade("Matt", 92);

            Jane.SetGrade(95);
            Joe.SetGrade(85);
            Melissa.SetGrade(90);
            Matt.SetGrade(92);
           
            #endregion
            
            Console.ReadKey();
        }
    }
}

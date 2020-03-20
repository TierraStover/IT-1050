using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentThree
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string student, string coursename)
        {
            
            this.Name =student;
            this.CourseName = coursename;
          
        }

        public void GetInstructor()
        {
            Console.WriteLine(Name + " teaches " + CourseName + ".");
        }
        public void SetStudentGrade(string Student, int Grade)
        {
            Console.WriteLine(Student + " got a " + Grade +".");
        }
    }
}

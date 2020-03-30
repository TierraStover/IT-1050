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
        
        public Instructor(string Name, string CourseName)
        {

            this.Name = Name;
            this.CourseName = CourseName;

        }

        public string GetInstructor()
        {
            return "\n\tIntructor: " +this.Name + "\tCourse: " + this.CourseName;
        }
        public void SetStudentGrade(Student studentName, int studentGrade)
        {
            studentName.SetGrade(studentGrade);        
        }
    }
}

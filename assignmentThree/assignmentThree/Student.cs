using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentThree
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string theirName, int theirGrade, Instructor theirTeacher)
        {
            
            this.Name = theirName;
            this.Grade = theirGrade;
            this.Teacher = theirTeacher;
        }
        public void SetGrade(int grade)
        {
            
            this.Grade += grade;
        }
    }
}

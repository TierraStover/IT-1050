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

        public Student(Instructor Teacher, string Name, int Grade)
        {

            this.Name = Name;
           this.Grade = Grade;
            this.Teacher = Teacher;

        }

        public void SetGrade(int grade)
        {

            this.Grade += grade;
        }

        public string GetStudent()
        {         
          return "\n Student Name: " + this.Name + "\n" + Teacher.GetInstructor() + "\t Grade: " + this.Grade +"\n";    
        }

        
    }
}

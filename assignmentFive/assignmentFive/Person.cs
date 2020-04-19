using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFive
{
    class Person
    {
        private string FirstName;
        private string LastName;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string GetPerson()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}

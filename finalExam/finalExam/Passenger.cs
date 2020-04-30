using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    class Passenger
    {
        private string Name;
        private double Weight;
        public Passenger(string name, double weight) 
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string GetName(string Name)
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}

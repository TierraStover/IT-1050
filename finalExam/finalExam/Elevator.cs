using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    class Elevator
    {
       private double MaxWeight;
       private Passenger[] Occupants;
       public Elevator(int maxOccupants, double maxWeight)
        {
            Passenger[] Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
          Passenger[] Occupants= new Passenger[index];
        }
        public double GetCurrentWeight()
        {
            return;
        }
        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }
}

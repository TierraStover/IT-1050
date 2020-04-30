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
       private Passenger[]Occupants;
       public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index]=passenger;
        }
        public double GetCurrentWeight()
        {
            double sumofweight=0;
            
            for (int i = 0; i < Occupants.Length; i++)
            {
              sumofweight += Occupants[i].GetWeight();
            }
            
            return sumofweight;
        }
        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }
}

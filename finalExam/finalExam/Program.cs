using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExam
{
    class Program
    {
        static void Main()
        {
            Passenger p1 = new Passenger("A1", 180);
            Passenger p2 = new Passenger("A2", 220);
            Passenger p3 = new Passenger("A1", 200);
            Passenger p4 = new Passenger("A2", 200);
            Passenger p5 = new Passenger("A3", 201);

            Elevator elevator1 = new Elevator(2, 400);
            Elevator elevator2 = new Elevator(3, 600);
        }
    }
}

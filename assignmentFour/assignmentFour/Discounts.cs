using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class Discounts
    {
        public static double TotalSavings=0;
        public static double cDiscount=0;
        public static double TixDiscount=0;
        public void GetDiscount() 
        {
            if(Concession.Candy >=4 || Concession.Candy % 4 == 0)
            {
            Concession.cPrice -= 1.99;
            Console.WriteLine("One Free Candy");
            }
            else
            {

            }
            if(Tickets.TicketCost >=3)
            {
           Console.WriteLine("Free Bag of Popcorn");
            }
            else 
            { 
            }
           if(Concession.Popcorn >=1 && Concession.lDrink >=1)
            {
             Tickets.eTicketCost -= 2;
            Console.WriteLine("$2 Off Your Movie Ticket");
            }
            else 
            {
            }
            Discounts.TotalSavings = Concession.cPrice + Tickets.TicketCost;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Tickets tix = new Tickets();
            Concession snacks = new Concession();
           

            tix.GetTickets();
            snacks.GetConcession();

           
            Tickets.TicketCost = Tickets.mTicketCost + Tickets.eTicketCost;
           
            if (Concession.Candy >= 4 || Concession.Candy % 4==0)
                {
                Concession.FreeCandy = (Concession.Candy/4) * 1.99;
                Concession.cDiscount = Concession.ConcessionCost-Concession.FreeCandy;
                Console.WriteLine(Concession.cDiscount);
                    Console.WriteLine((" Free Candy: " + Concession.Candy/4));
                }
                else
                {

                }
                if (Tickets.eTickets >= 3 && Concession.Popcorn>0)
                {

                Concession.offPop = 4.50;
                Concession.pDiscount = Concession.pPrice - Concession.offPop;
                Console.WriteLine(" Free Bag of Popcorn: One");

                }
                else
                {
                }
                if (Concession.Popcorn >=1 && Concession.lDrink >=1)
                {
                Tickets.offTix = 2;
                Tickets.TixDiscount = Tickets.TicketCost - Tickets.offTix;
                    Console.WriteLine(" Amount Off Your Movie Ticket(s): ");
                }
                else
                {
                }

            double Discount=Concession.FreeCandy + Tickets.offTix + Concession.offPop;
            double TotalCost = ((Tickets.TicketCost + Concession.ConcessionCost)-Discount);

            Console.WriteLine("\n\t\tThe Stover Movie Theater Receipt");
                Console.WriteLine(" \n\t\t\tTickets: " + Tickets.TicketCost + "\n\t\t\tConcession: " + Concession.ConcessionCost);
                Console.WriteLine("\t\t\tDiscount: "+Discount+"  \n\t\t\tTotal: " + TotalCost);
                Console.WriteLine("\n\t\tPress Any Key To Close Window");
                Console.ReadKey();   
            }
        }
} 
        
    


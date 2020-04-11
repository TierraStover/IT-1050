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
            //Discounts swag = new Discounts();

            tix.GetTickets();
            snacks.GetConcession();

            //swag.GetDiscount();
            Tickets.TicketCost = Tickets.mTicketCost + Tickets.eTicketCost;
           
            if (Concession.Candy >= 4 || Concession.Candy % 4==0)
                {
                Concession.FreeCandy = 1.99;
                Concession.cDiscount = Concession.ConcessionCost-=Concession.FreeCandy;
                Console.WriteLine(Concession.cDiscount);
                    Console.WriteLine("One Free Candy");
                }
                else
                {

                }
                if (Tickets.TicketCost >= 3)
                {
                
                    Console.WriteLine("Free Bag of Popcorn");

                }
                else
                {
                }
                if (Concession.Popcorn >=1 && Concession.lDrink >=1)
                {
                Tickets.offTix = 2;
                Tickets.TixDiscount = Tickets.TicketCost -= Tickets.offTix;
                    Console.WriteLine("$2 Off Your Movie Ticket");
                }
                else
                {
                }

            double Discount=Concession.FreeCandy + Tickets.offTix;
            double TotalCost = ((Tickets.TicketCost + Concession.ConcessionCost)-Discount);

            Console.WriteLine("\n\t\tThe Stover Movie Theater Receipt");
                Console.WriteLine(" \n\t\t\tTickets: " + Tickets.TicketCost + "\n\t\t\tConcession: " + Concession.ConcessionCost);
                Console.WriteLine("\t\t\tDiscount: "+Discount+"  \n\t\t\tTotal: " + TotalCost);
                Console.WriteLine("\n\t\tPress Any Key To Close Window");
                Console.ReadKey();   
            }
        }
} 
        
    


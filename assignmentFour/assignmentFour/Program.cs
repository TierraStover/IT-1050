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

            tix.GetDiscountList();

            tix.GetTicketsOptions();

            tix.GetTickets();

            snacks.GetConcession();

            Console.WriteLine("\n\tThe Stover-Cunningham Movie Theater Receipt\n");

            Tickets.TicketCost = Tickets.mTicketCost + Tickets.eTicketCost;

            snacks.GetDiscount();

            double Discount = Concession.FreeCandy + Tickets.offTix + Concession.offPop;

            double TotalCost = ((Tickets.TicketCost + Concession.ConcessionCost) - Discount);

            Console.WriteLine(" \n\t\t\tTickets: " + "$" + Tickets.TicketCost);
            Console.WriteLine("\t\t\tConcession: " + " $" + Concession.ConcessionCost);
            Console.WriteLine("\t\t\tDiscount: " + " $" + Discount);
            Console.WriteLine("  \t\t\tTotal: " + " $" + TotalCost);
            Console.WriteLine("\n\t\tPress Any Key To Close Window");
            Console.ReadKey();
        }
    }
        
} 
        
    


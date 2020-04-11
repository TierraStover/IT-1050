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
            Discounts swag = new Discounts();
        
            tix.GetTickets();
            snacks.GetConcession();
            swag.GetDiscount();
            Tickets.TicketCost = Tickets.mTicketCost + Tickets.eTicketCost; 
            double TotalCost=((Tickets.TicketCost + Concession.ConcessionCost) - Discounts.TotalSavings);

            Console.WriteLine("\n\t\tThe Stover Movie Theater Receipt");
            Console.WriteLine(" \n\t\t\tTickets: " + Tickets.TicketCost + "\n\t\t\tConcession: " +Concession.ConcessionCost);
            Console.WriteLine("\n\t\t\tDiscount:" + Discounts.TotalSavings + "  \n\t\t\tTotal: " + TotalCost);
            Console.WriteLine("\n\t\tPress Any Key To Close Window");           
            Console.ReadKey();
        }
    }
}


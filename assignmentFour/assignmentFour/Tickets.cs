using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class Tickets
    {
        public static double TicketCost;
        public static double mTicketCost;
        public static double eTicketCost;
        public static double eTickets;

        public void GetTickets()
        {
            Console.WriteLine("\t ************************************************************* ");
            Console.WriteLine("\t | Please Choose From The Following Movie Ticket Options:    | ");
            Console.WriteLine("\t |-----------------------------------------------------------| ");
            Console.WriteLine("\t | (1) - To Purchase Movie Tickets For The Matinee Showings. | ");
            Console.WriteLine("\t | (2) - To Purchase Movie Tickets For The Evening Showings. | ");
            Console.WriteLine("\t ************************************************************* ");

            Console.Write("\n Your Choice: ");
            string Tixchoice = Console.ReadLine();

            if (Tixchoice == "1")
            {

                Console.Write(" \n How Many Child Matinee Tickets?: ");
                double cTix = double.Parse(Console.ReadLine());

                Console.Write(" How Many Adult Matinee Tickets?: ");
                double aTix = double.Parse(Console.ReadLine());

                Console.Write(" How Many Senior Matinee Tickets?: ");
                double sTix = double.Parse(Console.ReadLine());

                double cPrice = cTix * 3.99;
                Console.WriteLine("\n " + cTix + " Tickets Costs " + cPrice + " Dollars In Total.");

                double aPrice = aTix * 5.99;
                Console.WriteLine(" " + aTix + " Tickets Costs " + aPrice + " Dollars In Total.");

                double sPrice = sTix * 4.50;
                Console.WriteLine(" " + sTix + " Tickets Costs " + sPrice + " Dollars In Total.");

               mTicketCost = cPrice + aPrice + sPrice;

                Console.WriteLine(" \n\tThe Total Cost Of Your Matinee Tickets Are: " + mTicketCost + " Dollars.");
            }
            else if (Tixchoice == "2")
            {
                Console.Write(" \n How Many Child Evening Tickets? : ");
                double cTix = double.Parse(Console.ReadLine());

                Console.Write(" How Many Adult Evening Tickets? : ");
                double aTix = double.Parse(Console.ReadLine());

                Console.Write(" How Many Senior Evening Tickets? : ");
                double sTix = double.Parse(Console.ReadLine());
                
                eTickets = cTix + aTix + sTix;
 
                double cPrice = cTix * 6.99;
                Console.WriteLine("\n " + cTix + " Tickets Costs " + cPrice + " Dollars In Total.");

                double aPrice = aTix * 10.99;
                Console.WriteLine(" " + aTix + " Tickets Costs " + aPrice + " Dollars In Total.");

                double sPrice = sTix * 8.50;
                Console.WriteLine(" " + sTix + " Tickets Costs " + sPrice + " Dollars In Total.");

                eTicketCost = cPrice + aPrice + sPrice;
                Console.WriteLine("\n\t The Total Cost Of Your Evening Tickets Are: " + eTicketCost + " Dollars.");
            }
            else
            {

                Console.WriteLine(" \nInvalid Choice.\n");
                GetTickets();
            }
            
        }
    }
}

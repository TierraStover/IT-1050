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
        public static double TixDiscount;
        public static double offTix;

        public void GetTickets()
        {
            Console.Write("\n Your Choice: ");
            string Tixchoice = Console.ReadLine();

            if (Tixchoice == "1")
            {
                GetMTix();
            }
            else if (Tixchoice == "2")
            {
                GetETix();
            }
            else
            {
                Console.WriteLine(" \nInvalid Choice. Please Select Option 1 or 2.\n");
                GetTicketsOptions();
                GetTickets();
            }
        }

        public void GetMTix()
        {
            Console.WriteLine("\n\t\tYou Have Selected The Matinee!\n");

            Console.Write(" \n How Many Child Matinee Tickets?: ");
            double cTix = double.Parse(Console.ReadLine());

            Console.Write(" How Many Adult Matinee Tickets?: ");
            double aTix = double.Parse(Console.ReadLine());

            Console.Write(" How Many Senior Matinee Tickets?: ");
            double sTix = double.Parse(Console.ReadLine());

            double cPrice = cTix * 3.99;
            Console.WriteLine("\n " + cTix + " Child Ticket(s) Costs " + cPrice + " Dollars In Total.");

            double aPrice = aTix * 5.99;
            Console.WriteLine(" " + aTix + " Adult Ticket(s) Costs " + aPrice + " Dollars In Total.");

            double sPrice = sTix * 4.50;
            Console.WriteLine(" " + sTix + " Senior Ticket(s) Costs " + sPrice + " Dollars In Total.");

            mTicketCost = cPrice + aPrice + sPrice;

            Console.WriteLine(" \n\tThe Total Cost Of Your Matinee Tickets Are: " + mTicketCost + " Dollars.");
        }
        public void GetETix()
        {
            Console.WriteLine("\n\t\tYou Have Selected The Evening!\n");

            Console.Write(" \n How Many Child Evening Tickets? : ");
            double cTix = double.Parse(Console.ReadLine());

            Console.Write(" How Many Adult Evening Tickets? : ");
            double aTix = double.Parse(Console.ReadLine());

            Console.Write(" How Many Senior Evening Tickets? : ");
            double sTix = double.Parse(Console.ReadLine());

            eTickets = cTix + aTix + sTix;

            double cPrice = cTix * 6.99;
            Console.WriteLine("\n " + cTix + " Child Ticket(s) Costs " + cPrice + " Dollars In Total.");

            double aPrice = aTix * 10.99;
            Console.WriteLine(" " + aTix + " Adult Ticket(s) Costs " + aPrice + " Dollars In Total.");

            double sPrice = sTix * 8.50f;
            Console.WriteLine(" " + sTix + " Senior Ticket(s) Costs " + sPrice + " Dollars In Total.");

            eTicketCost = cPrice + aPrice + sPrice;
            Console.WriteLine("\n\t The Total Cost Of Your Evening Tickets Are: " + eTicketCost + " Dollars.");
        }
        public void GetDiscountList()
        {
            Console.WriteLine(" \n\t\t\t*** DISCOUNTS AND PROMOTIONS ***");
            Console.WriteLine(" \n\t 1) Each Purchase Of A Popcorn And A Large Drink");
            Console.WriteLine(" \t\t Earns $2 OFF Of One Movie Ticket.");
            Console.WriteLine(" \n\t 2)The Purchase of 3 OR More Tickets To An Evening Show");
            Console.WriteLine(" \t\t\t Earns 1 FREE Bag Of Popcorn. ");
            Console.WriteLine(" \n\t 3) For Each 3 Boxes of Candy, You Earn A 4th Box Of Candy For Free.\n");
        }

        public void GetTicketsOptions()
        {
            Console.WriteLine("\t ************************************************************* ");
            Console.WriteLine("\t | Please Choose From The Following Movie Ticket Options:    | ");
            Console.WriteLine("\t |-----------------------------------------------------------| ");
            Console.WriteLine("\t | (1) - To Purchase Movie Tickets For The Matinee Showings. | ");
            Console.WriteLine("\t | (2) - To Purchase Movie Tickets For The Evening Showings. | ");
            Console.WriteLine("\t ************************************************************* ");
        }

    }
}


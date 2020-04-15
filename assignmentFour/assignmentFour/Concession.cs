using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFour
{
    class Concession
    {

        public static double ConcessionCost;
        public static double Popcorn;
        public static double lDrink;
        public static int Candy;
        public static double FreeCandy;
        public static double cDiscount;
        public static double pDiscount;
        public static double pPrice;
        public static double offPop;
        public void GetConcession()
        {

            Console.WriteLine(" \n Would You Like To Purchase Food or Drinks From Concession?(Y/N) ");
            Console.Write("\n Your Choice: ");
            string Snackchoice = Console.ReadLine();

            if (Snackchoice == "y" || Snackchoice == "Y")
            {
                Console.Write(" \n How Many Small Drinks? : ");
                double sDrink = double.Parse(Console.ReadLine());

                Console.Write(" How Many Large Drinks? : ");
                lDrink = double.Parse(Console.ReadLine());

                Console.Write(" How Many Hot Dogs? : ");
                double hDog = double.Parse(Console.ReadLine());

                Console.Write(" How Many Boxes Of Candy? : ");
                Candy = int.Parse(Console.ReadLine());

                Console.Write(" How Many Bags Of Popcorn? : ");
                Popcorn = double.Parse(Console.ReadLine());

                double lDPrice = lDrink * 5.99;
                Console.WriteLine("\n " + lDrink + " Large Drink(s) Costs " + lDPrice + " Dollars In Total.");

                double sDPrice = sDrink * 3.50;
                Console.WriteLine(" " + sDrink + " Small Drink(s) Costs " + sDPrice + " Dollars In Total.");

                double hDPrice = hDog * 3.99;
                Console.WriteLine(" " + hDog + " Hot Dog(s) Costs " + hDPrice + " Dollars In Total.");

                double cPrice = Candy * 1.99;
                Console.WriteLine(" " + Candy + " Box Of Candy Costs " + cPrice + " Dollars In Total.");

                double pPrice = Popcorn * 4.50;
                Console.WriteLine(" " + Popcorn + " Bag Of Popcorn " + pPrice + " Dollars In Total.");

                ConcessionCost = sDPrice + lDPrice + hDPrice + cPrice + pPrice;
                Console.WriteLine(" \n\tThe Total Cost Of Your Concession Items Are: " + ConcessionCost + " Dollars.");
            }
            else if (Snackchoice == "n" || Snackchoice == "N")
            {
                ConcessionCost = 0;
                Console.WriteLine("\n\tThe Total Cost Of Your Concession Items Are: " + ConcessionCost + " Dollars.");
            }
            else
            {

                Console.WriteLine(" \nInvalid Choice. Please Press Y or N.");
                GetConcession();
            }
        }
        public void GetDiscount()
        {
            if (Concession.Candy >= 4)
            {
                Concession.FreeCandy = (Concession.Candy / 4) * 1.99;
                Concession.cDiscount = Concession.ConcessionCost - Concession.FreeCandy;
                Console.WriteLine(" \t\tYou Earned " + Concession.Candy / 4 + " Free Box(es) of Candy ");
            }

            if (Tickets.eTickets >= 3 && Concession.Popcorn > 0)
            {
                Concession.offPop = 4.50;
                Concession.pDiscount = Concession.pPrice - Concession.offPop;
                Console.WriteLine(" \t\tYou Have Earned 1 FREE Popcorn");
            }
            
            if (Concession.Popcorn >= 1 && Concession.lDrink >= 1)
            {
                if (Concession.Popcorn < Concession.lDrink)
                {
                    Tickets.offTix = Concession.Popcorn * 2;
                    Tickets.TixDiscount = Tickets.TicketCost - Tickets.offTix;
                    Console.WriteLine(" \t\tYou Have Earned $" + Tickets.offTix + " OFF Your Ticket(s) ");
                }
                else
                {
                    Tickets.offTix = Concession.lDrink * 2;
                    Tickets.TixDiscount = Tickets.TicketCost - Tickets.offTix;
                    Console.WriteLine(" \t\tYou Have Earned $" + Tickets.offTix + " OFF Your Ticket(s): ");
                }
            }
        }
    }
}

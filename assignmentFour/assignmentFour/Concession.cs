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
        public static double lDrink=0;
        public static double Candy;
        public static double cPrice=0;
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
                double lDrink = double.Parse(Console.ReadLine());

                Console.Write(" How Many Hot Dogs? : ");
                double hDog = double.Parse(Console.ReadLine());

                Console.Write(" How Many Boxes Of Candy? : ");
                Candy = double.Parse(Console.ReadLine());

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

                Console.WriteLine(" \nInvalid Choice.");
                GetConcession();
            }
        }
    }
}

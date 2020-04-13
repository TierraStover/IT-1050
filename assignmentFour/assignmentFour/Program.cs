﻿using System;
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
            Console.WriteLine(" \t\t\t*** DISCOUNTS AND PROMOTIONS ***");
            Console.WriteLine(" \n\t 1) Each Purchase Of A Popcorn And A Large Drink");
            Console.WriteLine(" \t\t Earns $2 OFF Of One Movie Ticket.");
            Console.WriteLine(" \n\t 2)If 3 OR More People Purchase Tickets To An Evening Show");
            Console.WriteLine(" \t\t\t Earns 1 FREE Bag Of Popcorn. ");
            Console.WriteLine(" \n\t 3) For Each 3 Boxes of Candy, You Earn A 4th Box Of Candy For Free.\n");
            
            Tickets tix = new Tickets();
            Concession snacks = new Concession();

            tix.GetTickets();
            snacks.GetConcession();

            Console.WriteLine("\n\tThe Stover-Cunningham Movie Theater Receipt");

            Tickets.TicketCost = Tickets.mTicketCost + Tickets.eTicketCost;
           
            if (Concession.Candy >= 4 || Concession.Candy % 4==0)
            {
                Concession.FreeCandy = (Concession.Candy / 4) * 1.99;
                Concession.cDiscount = Concession.ConcessionCost - Concession.FreeCandy;
                Console.WriteLine(" \n\t\tYou Earned "  + Concession.Candy / 4 + " Free Boxes of Candy ");
            }
            else
            {

            }
                
            if (Tickets.eTickets >= 3 && Concession.Popcorn>0)
            {
                Concession.offPop = 4.50;
                Concession.pDiscount = Concession.pPrice - Concession.offPop;
                Console.WriteLine(" \t\tYou Have Earned 1 FREE Popcorn");
            }
            else
            {
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
            else
            {
            }

            double Discount=Concession.FreeCandy + Tickets.offTix + Concession.offPop;
            double TotalCost = ((Tickets.TicketCost + Concession.ConcessionCost)-Discount);

            Console.WriteLine(" \n\t\t\tTickets: " + Tickets.TicketCost);
            Console.WriteLine( "\t\t\tConcession: " + Concession.ConcessionCost);
            Console.WriteLine("\t\t\tDiscount: "+ Discount);
            Console.WriteLine("  \t\t\tTotal: " + TotalCost);
            Console.WriteLine("\n\t\tPress Any Key To Close Window");
            Console.ReadKey();   
            }
        }
} 
        
    


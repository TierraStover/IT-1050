using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinderella
{
    class Program
    {
		public static void Main()
		{
			Gametitle();
		}
		public static void Gametitle()
		{
			string name;
			string start;
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tSPINDERELLA");
			Console.Write("Hello! Please Enter Your Name:");
			name = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Hi {0}, Welcome To Spinderella!", name);
			Console.Write("\n\tAre You Ready To Start The Game?(Y/N)");
			start = Console.ReadLine().ToUpper();

			if (start == "y" || start == "Y" || start == "yes" || start == "Yes" | start == "YES")
			{

				Console.Clear();
				Gameintro();
			}
			else
			{
				Console.Clear();
				Gametitle();
			}
		}
		public static void Gameintro()
		{
			Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tSPINDERELLA");
			Console.WriteLine("\n\t Once upon a time, there was a beautiful and talented DJ named Spinderella.\n\t Spinderella lived and worked with her cruel manager Pebbles and her two group members Salt n Pepa. They treated like 'The Help'.");
			Console.WriteLine("\t Spinderella had to write all the song lyrics and produce all the beats. Her group members never did any work.");
			Console.WriteLine("\t One day a bike messenger came to their home studio and brought a letter from the King of Pop, Michael Jackson. Pebbles read the letter aloud. \n \tThe King of Pop was giving a Black or White for Prince that night. Every Recording Artist was invited.");
			Console.ReadLine();
			Console.WriteLine("\n\t\t Spinderella says:");
			Console.WriteLine("\n\t\t\t (A)Nothing-Of course they know she wants to go, who wouldn’t. It’s Prince!!!");
			Console.WriteLine("\t\t\t (B)That’s means I can go!");
			Console.Write("\n\t\t\t\t Your Choice:");

			Firstchoice();

		}
		public static void Firstchoice()
		{
			string choice1;
			choice1 = Console.ReadLine().ToLower();
			switch (choice1)
			{
				case "a":
				case "A":
				case "Nothing":
				case "nothing":
					{
						Console.WriteLine("\nA closed mouth doesn’t get feed. She should have spoken up. As Spinderella gets dressed they drive away without her. GAME OVER!!!!");
						Console.ReadLine();
						Gameover();
						Console.ReadLine();
						Console.Clear();
						break;

					}
				case "b":
				case "B":
				case "That’s means I can go!":
				case "that’s means i can go!":
				case "That’s means i can go!":
				case "that’s means I can go!":
					{
						Console.WriteLine("\nYou may go. -If you get all your work done and find something to wear.\nSpinderella quickly calls an Uber to take her to the mall. Pebbles calls as Spinderella is shopping for a dress at the mall and orders Spinderella to come back to the studio. \nShe wants her to write a song for Dawn, Cindy, Terry and Maxine aka En Vogue before the ball starts. ");
						Console.ReadLine();
						Secondchoice();
						break;

					}
				default:
					{
						Console.WriteLine("Do Not Understand Your Choice. Please Press Enter And Select Again");
						Console.ReadLine();
						Console.Clear();
						Gameintro();
						break;
					}
			}
		}
		public static void Secondchoice()
		{
			string choice2;
			Console.WriteLine("\t\tWhat does Spinderella do?");
			Console.WriteLine("\n\t\t\t(A)She goes back to the studio.");
			Console.WriteLine("\t\t\t(B)She keeps shopping for a dress to wear to the ball.");
			Console.Write("\n\t\t\t\t\tYour Choice:");
			choice2 = Console.ReadLine().ToLower();

			if (choice2 == "a" || choice2 == "A")
			{
				Console.WriteLine("\nEn Vogue felt sorry for Spinderella and agreed to give her a dress and shoes to wear to the ball. Spinderella helped Salt n Pepa get dressed for the ball after she finished writing the song.\nIt was almost time to leave for the ball and Spinderella had nothing to wear. So, she couldn’t go to the ball. Spinderella slowly climbed the stairs to her room and as she opened the door, \nEn Vogue sang “Surprise!” Her Blue Versace dress and Silver Louboutin Heels were beautiful.She got dressed and hurried downstairs. Salt n Pepa tore her dress to rags on sight. ");
				Thirdchoice();
			}


			else if (choice2 == "b" || choice2 == "B")
			{
				Console.WriteLine("\nA pick pocket steals her wallet and phone before she could pay for her dress or call Uber to take her home. GAME OVER!!!!");
				Gameover();

			}
			else
			{
				Console.Clear();
				Secondchoice();
			}
		}
		public static void Thirdchoice()
		{

			string choice3;
			Console.WriteLine("\n\t\tWhat does Spinderella do?");
			Console.WriteLine("\n\t\t\t(A)Fights Salt n Pepa for tearing her dress.");
			Console.WriteLine("\t\t\t(B)Runs into the backyard and cries. While Salt n Pepa goes to the ball with Pebbles. ");
			Console.Write("\n\t\t\t\t\tYour Choice:");
			choice3 = Console.ReadLine().ToLower();

			if (choice3 == "a" || choice3 == "A")
			{
				Console.WriteLine("\nIt was Salt n Pepa, and Pebbles word against hers as to who started the fight. So, Spinderella gets arrested for Assault. GAME OVER!!!!");
				Gameover();
			}
			else if (choice3 == "b" || choice3 == "B")
			{
				Console.WriteLine("\nAs Spinderella cried she didn’t notice the lights that danced and twinkled all around her. The lights turned into Queen Latifah.");
				Forthchoice();
			}
			else
			{
				Console.Clear();
				Thirdchoice();
			}
		}

		public static void Forthchoice()
		{
			string choice4;
			Console.WriteLine("\n\t\tWhat does Spinderella do?");
			Console.WriteLine("\n\t\t\t(A)Stays and talks to Queen Latifah.");
			Console.WriteLine("\t\t\t(B)Runs in the house, locks the door and hides.");
			Console.Write("\n\t\t\t\t\tYour Choice:");
			choice4 = Console.ReadLine().ToLower();

			if (choice4 == "a" || choice4 == "A")
			{
				Console.WriteLine("\nQueen Latifah waved her wand and turned Spinderella torn dress into a Vera Wang gown. She waved her wand again and a Golden Rolls Royce pulled into the driveway. \nIt was Spinderella’s ride to the ball. Spinderella promised to be home before midnight. Prince starred in wonder the moment Spinderella made her entrance. \nPrince asked Spinderella to dance. They danced all around the ballroom. Suddenly the began to struck midnight.");
				Fifthchoice();
			}
			else if (choice4 == "b" || choice4 == "B")
			{
				Console.WriteLine("\nQueen Latifah is offended and leaves. Spinderella comes out of hiding when she thinks Queen Latifah is gone. \nSpinderella stays home eating ribs and ice cream in front of tv while watching Love and Hip Hop New York for the rest of the night. Game Over!!!!");
				Gameover();
			}
			else
			{
				Console.Clear();
				Forthchoice();
			}
		}
		public static void Fifthchoice()
		{
			string choice5;
			Console.WriteLine("\n\t\tWhat does Spinderella do?");
			Console.WriteLine("\n\t\t\t(A)Jumps on the turn tables.");
			Console.WriteLine("\t\t\t(B)Runs out the ball because she promised to be home before midnight.");
			Console.Write("\n\t\t\t\t\tYour Choice:");
			choice5 = Console.ReadLine().ToLower();

			if (choice5 == "a" || choice5 == "A")
			{
				Console.WriteLine("\nSpinderella dress turns back to the way it was but everyone thinks she is making a fashion statement. So, other women start tearing their dresses. \nPrince is impressed by Spinderella skills on the turn table and invites her to join The Revolution. \nSpinderella fires Pebbles and leaves Salt n Pepa. She goes on tour with Prince and becomes the most famous and richest female DJ in the world. THE END!!!!");

			}
			else if (choice5 == "b" || choice5 == "B")
			{
				Console.WriteLine("\nSpinderella falls as she runs down the stairs in heels and hits her head. She is in a coma. GAME OVER!!!");
				Gameover();
			}
			else
			{
				Console.Clear();
				Fifthchoice();
			}
		}

		public static void Wingame()
		{
		}

		public static void Gameover()
		{
		}



	}
}

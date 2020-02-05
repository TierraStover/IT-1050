using System;

public class Program
{
	public static void Main()
	{
		
		Console.Write("Please Enter Your First Name: ");
		string firstName = Console.ReadLine();

		Console.Write("Please Enter Your Middle Initial:");
		string middleInitial = Console.ReadLine();

		Console.Write("Please Enter Your Last Name:");
		string lastName = Console.ReadLine();

		Console.Write("\nPlease Enter Your Height In Feet (Ex. 3, 4, 5, 6, or 7):");
		int heightFeet = int.Parse(Console.ReadLine());

		Console.Write("\nYou are" + " " + heightFeet + " Feet" + " " + "and How Many Inches (Ex. 0, 1, 2.25, 3.50 or 4.75):");
		double heightInches = double.Parse(Console.ReadLine());

		double totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

		string fullName = firstName + " " + middleInitial + " " + lastName;

		Console.Write("\nTo be eligible to vote, you must be:\n\n\t(1) a citizen,and\n\t(2) you must be at least 18 years old.");
		
		Console.Write("\n\nAre you an US Citizen?(True/False):");
		bool isCitizen = bool.Parse(Console.ReadLine());

		Console.Write("\nPlease Enter Your Age:");
		int age = int.Parse(Console.ReadLine());

		bool canVote =(age >= 18) && isCitizen;
		Console.WriteLine("\n\n\t\t\t" + fullName + "'s Results:");

		Console.WriteLine("\n\tYour Height of " + heightFeet + " Feet and " + heightInches + " Inches is equal to " + totalHeightCM + " Centimeters");

		Console.WriteLine("\tYou Are Eligible To Vote:" + " " + canVote);

		Console.WriteLine("\n\t\t\tPress Any Key To Close This Window");
		Console.ReadKey();

	}
}
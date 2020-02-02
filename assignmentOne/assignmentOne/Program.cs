using System;

public class Program
{
	public static void Main()
	{
		string firstName;
		string middleInitial;
		string lastName;
		string fullName;

		int age;
		int heightFeet;

		bool isCitizen;
		bool canVote;

		double heightInches;
		double totalHeightCM;

		Console.Write("Please Enter Your First Name: ");
		firstName = Console.ReadLine();

		Console.Write("Please Enter Your Middle Initial:");
		middleInitial = Console.ReadLine();

		Console.Write("Please Enter Your Last Name:");
		lastName = Console.ReadLine();

		Console.Write("\nPlease Enter Your Height In Feet (Ex. 3, 4, 5, 6, or 7):");
		heightFeet = int.Parse(Console.ReadLine());

		Console.Write("You are" + " " + heightFeet + " Feet" + " " + "and How Many Inches (Ex. 0, 1, 2.25, 3.50 or 4.75):");
		heightInches = double.Parse(Console.ReadLine());

		totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

		fullName = firstName + " " + middleInitial + " " + lastName;

		Console.Write("\nTo be eligible to vote, you must be:\n\n\t(1) a citizen,and\n\t(2) you must be at least 18 years old.");
		
		Console.Write("\n\nAre you an US Citizen?(Yes/No):");
		isCitizen = Console.ReadLine().ToUpper().StartsWith("Y");

		Console.Write("Please Enter Your Age:");
		age = int.Parse(Console.ReadLine());

		if (age >= 18 && isCitizen == true)
		{
			canVote = true;
		}
		else
		{
			canVote = false;
		}
		Console.WriteLine("\n\n\t\t\t" + fullName + "'s Results:");

		Console.WriteLine("\n\tYour Height of " + heightFeet + " Feet and " + heightInches + " Inches is equal to " + totalHeightCM + " Centimeters");

		Console.WriteLine("\nEligible To Vote?(True/False):" + " " + canVote);

		Console.WriteLine("\n\t\t\tPress Any Key To Close The Window");
		Console.ReadKey();

	}
}
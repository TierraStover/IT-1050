using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        static void Main()
        {
            // Declare Variables
            string name;
            int weight;
            int height;
            double BMI;
            string input1;
            int input2;
            int input3;

            // Get Input From User
            Console.Write("Please Enter Your Name: ");
            input1 = Console.ReadLine();

            Console.Write("Please Enter Your Weight in Pounds: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Your Height in Inches: ");
            input3 = Convert.ToInt32(Console.ReadLine());

            //Calculate BMI
            name = input1;
            weight = input2;
            height = input3;

            BMI = ((double)weight * 703) / (height * height);

            //Display Results

            Console.WriteLine("\nHello," + name);
            System.Console.WriteLine("Your Body Mass Index is:" + BMI);
            Console.WriteLine("\nBMI Standard Weight Status Catergories");
            Console.WriteLine("\tUnderweight: Less than 18.50");
            Console.WriteLine("\tNormal weight: 18.5-24.99");
            Console.WriteLine("\tOverweight: 25-29.99");
            Console.WriteLine("\tObese: 30 or greater");

            //press any key to end
            Console.ReadKey();

        }
    }
}

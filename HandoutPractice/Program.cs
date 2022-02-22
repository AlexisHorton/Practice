using System;
using System.Linq;

namespace HandoutPractice
{
    class Program
    {
        static void Main(string[] args)
        { // BASIC FUNCTIONS: 

            //  *EXCERCISE 1* //

            //Console.WriteLine("Enter some text!:");
            //string response = Console.ReadLine();
            //Console.WriteLine("This should print out whatever text you just entered:");
            //Console.WriteLine(response);
            //

            // *EXCERCISE 2* //

            //Console.Write("Enter ANY number you want:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Here's your number plus 1! :{num + 1}");
            //

            // *EXCERCISE 3* //

            //Console.Write("Enter ANY number you want:");
            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Here's your number plus .5! :{num + .5}");
            //

            // *EXCERCISE 4* //

            //Console.Write("Enter your first number:");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter your second number:");
            //double num2 = double.Parse(Console.ReadLine());
            //double sum = num1 + num2;
            //Console.WriteLine($"Here's the sum of your numbers: {num1} + {num2} = {sum}.");
            //

            // *EXCERCISE 5* //

            //Console.Write("Enter your first number:");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter your second number:");
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The product of your two numbers: {num1 * num2}.");
            //

            // *EXCERCISE 6* //
            string response = "";
            do
            {
                Console.WriteLine("What up do hoes!");
                Console.WriteLine("Again? Y/N");
                response = Console.ReadLine();
            } while (response != "n");
            Console.WriteLine("Okay, goodbye!");
        }
    }
}

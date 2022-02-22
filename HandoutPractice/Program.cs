using System;
using System.Linq;

namespace HandoutPractice
{
    class Program
    {
        static void Main(string[] args)
        { // BASIC FUNCTIONS: 

            //  *EXCERCISE 1* //

            Console.WriteLine("Enter some text!:");
            string response = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(response);
            //

            // *EXCERCISE 2* //
            Console.Write("Enter ANY number you want:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Here's your number plus 1! :{num + 1}");
        }
    }
}

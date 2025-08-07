using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMe
{
    internal class Program
    {
        private static string input;
        static void Main(string[] args)
        {
            int number;
            bool isValid;

            do
            {
                Console.Write("Enter numeric input (digits only): ");
                input = Console.ReadLine();

                // Validate input contains only digits using regex
                isValid = !string.IsNullOrWhiteSpace(input) && System.Text.RegularExpressions.Regex.IsMatch( input, @"^\d+$");

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter digits only (0-9).");
                }
            } while (!isValid);

            // Convert to integer and add 10
            number = int.Parse(input) + 10;

            // Display result
            Console.WriteLine($"Result after adding 10: {number}");

        }
    }
}

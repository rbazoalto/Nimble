using System;
using System.Collections.Generic;

namespace Nimble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // objects initialization
            InputParser inputParser = new InputParser();
            NumberValidator numberValidator = new NumberValidator();
            Calculator calculator = new Calculator();
            int res = 0;
            string message = string.Empty;
            string upperBoundString = string.Empty;
            int upperBound = 0;
            bool success = false;
            string denyNegativeNumbersString = string.Empty;
            bool denyNegativeNumbers = true;

            // We will continue until Ctrl-C is pressed
            while (true)
            {
                Console.WriteLine("Please add numbers to be added separated by comma or '\\n' char (i.e. 1,2\\n3) Negative numbers are not allowed.");
                
                Console.Write("Do you want to deny negative numbers?(y/n) [default: y] : ");
                denyNegativeNumbersString = Console.ReadLine();
                denyNegativeNumbersString = denyNegativeNumbersString.Trim().ToLower();
                if (denyNegativeNumbersString == "n" || denyNegativeNumbersString == "no")
                {
                    denyNegativeNumbers = false;
                }

                Console.Write("Introduce the upper bound number [default: 1000] : ");
                upperBoundString = Console.ReadLine();
                success = int.TryParse(upperBoundString.Trim(), out upperBound);

                Console.Write("You can also define your own delimiters using the following format (//[##][!!]\\n1##5!!4): ");
                string input = Console.ReadLine();
                // We replace the string with the \n char
                input = input.Replace("\\n", "\n");

                try
                {
                    // First we parse the string to have the list of parameters
                    string[] parsedInput = inputParser.Parse(input);

                    // Then we validate the parameters to get a list of numbers
                    List<int> numbers = numberValidator.Validate(parsedInput, upperBound, denyNegativeNumbers);

                    // Finally, we calculate the sum of the numbers
                    res = calculator.Sum(numbers, out message);

                    // Print the result
                    Console.WriteLine(message);

                    // Finally, we calculate the multiplication of the numbers
                    res = calculator.Multiply(numbers, out message);

                    // Print the result
                    Console.WriteLine(message);

                    // Finally, we calculate the multiplication of the numbers
                    res = calculator.Substract(numbers, out message);

                    // Print the result
                    Console.WriteLine(message);


                    // Finally, we calculate the multiplication of the numbers
                    res = calculator.Divide(numbers, out message);

                    // Print the result
                    Console.WriteLine(message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("ERROR: {0}.", ex.Message);
                }
            }
        }
    }
}

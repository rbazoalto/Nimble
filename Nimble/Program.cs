using System;
using System.Collections.Generic;

namespace Nimble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please add numbers to be added separated by comma or '\\n' char (i.e. 1,2\\n3) Negative numbers are not allowed.");
            Console.Write("You can also define your own delimiters using the following format (//[##][!!]\\n1##5!!4): ");
            string input = Console.ReadLine();
            // We replace the string with the \n char
            input = input.Replace("\\n", "\n");
            // objects initialization
            InputParser inputParser = new InputParser();
            NumberValidator numberValidator = new NumberValidator();
            Calculator calculator = new Calculator();
            int res = 0;
            string message = string.Empty;

            try
            {
                // First we parse the string to have the list of parameters
                string[] parsedInput = inputParser.Parse(input);

                // Then we validate the parameters to get a list of numbers
                List<int> numbers = numberValidator.Validate(parsedInput);

                // Finally, we calculate the sum of the numbers
                res = calculator.Sum(numbers, out message);

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

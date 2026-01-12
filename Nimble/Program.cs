using System;
using System.Collections.Generic;

namespace Nimble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please add numbers to be added separated by comma (i.e. 1,2,3): ");
            string input = Console.ReadLine();
            
            // objects initialization
            InputParser inputParser = new InputParser();
            NumberValidator numberValidator = new NumberValidator();
            Calculator calculator = new Calculator();
            int res = 0;

            try
            {
                // First we parse the string to have the list of parameters
                string[] parsedInput = inputParser.Parse(input);

                // Then we validate the parameters to get a list of numbers
                List<int> numbers = numberValidator.Validate(parsedInput);

                // Finally, we calculate the sum of the numbers
                res = calculator.Sum(numbers);

                // Print the result
                Console.WriteLine("{0} = {1}.", input, res);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("ERROR: {0}.", ex.Message);
            }
        }
    }
}

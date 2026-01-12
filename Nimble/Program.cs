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
            string input = "1,2";
            
            // First we parse the string to have the list of parameters
            string[] parsedInput = inputParser.Parse(input);

            // Then we validate the parameters to get a list of numbers
            List<int> numbers = numberValidator.Validate(parsedInput);

            // Finally, we calculate the sum of the numbers
            int res = calculator.Sum(numbers);

            // Print the result
            Console.WriteLine("{0} = {1}.", input, res);
        }
    }
}

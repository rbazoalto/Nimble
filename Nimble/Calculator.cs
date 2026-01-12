using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public class Calculator
    {
        public Calculator()
        {

        }

        /// <summary>
        /// Returns the Sum of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <returns>The sum of the numbers.</returns>
        public int Sum(List<int> numbers)
        {
            int res = 0;
            foreach (var item in numbers)
            {
                res += item;
            }

            return res;
        }

        /// <summary>
        /// Returns the Sum of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <param name="message">The formatted operation like 1+2</param>
        /// <returns>The sum of the numbers</returns>
        public int Sum(List<int> numbers, out string message)
        {
            int res = 0;
            string operation = string.Empty;

            foreach (var item in numbers)
            {
                res += item;
                operation = operation + item + "+";
            }

            message = operation.Remove(operation.Length - 1) + " = " + res; 
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public class NumberValidator
    {
        public NumberValidator()
        {

        }

        /// <summary>
        /// Obtains the list of numbers to be added from the parameters list.
        /// </summary>
        /// <param name="parsedInput">Arrayy with the parameters</param>
        /// <returns>A list of numbers</returns>
        public List<int> Validate(string[] parsedInput, int upperBound = 1000, bool denyNegativeNumbers = true)
        {
            bool success = false;
            int value = 0;
            List<int> numbers = new List<int>();
            string negativeNumbers = string.Empty;

            // if the upperBound is negative or zero, we use the default value.
            if (upperBound < 1)
            {
                upperBound = 1000;
            }
            
            foreach (var item in parsedInput)
            {
                success = int.TryParse(item, out value);
                // only valid numbers smaller than the upper bound are taken
                if (success && value <= upperBound)
                {
                    // if this is a negative number, we will collect them.
                    if (value < 0 && denyNegativeNumbers)
                    {
                        negativeNumbers = negativeNumbers + value + ",";
                        continue;
                    }
                    numbers.Add(value);
                }
                else
                {
                    numbers.Add(0);
                }
            }

            int lenght = negativeNumbers.Length;

            // if negative numbers were detected, an exception is thrown
            if (lenght > 0)
            {
                // We remove the last ',' from the negative numbers list.
                throw new ArgumentException("The following negative numbers were detected: " + negativeNumbers.Remove(lenght - 1));
            }

            return numbers;
        }
    }
}

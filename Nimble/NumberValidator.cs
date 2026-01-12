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
        public List<int> Validate(string[] parsedInput)
        {
            bool success = false;
            int value = 0;
            List<int> numbers = new List<int>();
            string negativeNumbers = string.Empty;

            foreach (var item in parsedInput)
            {
                success = int.TryParse(item, out value);
                if (success)
                {
                    // if this is a negative number, we will collected them.
                    if (value < 0)
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

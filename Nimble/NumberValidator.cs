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

            foreach (var item in parsedInput)
            {
                success = int.TryParse(item, out value);
                if (success)
                {
                    numbers.Add(value);
                }
                else
                {
                    numbers.Add(0);
                }
            }

            return numbers;
        }
    }
}

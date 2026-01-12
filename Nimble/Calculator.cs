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
    }
}

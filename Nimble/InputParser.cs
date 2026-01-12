using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nimble
{
    public class InputParser
    {
        public static readonly string[] _defaultDelimiters = new string[] { ",", "\n" };

        public InputParser()
        {

        }

        /// <summary>
        /// This parse the input getting the list of parameters
        /// </summary>
        /// <param name="input">Formatted string with the operation</param>
        /// <returns>An array with all the parameters</returns>
        public string[] Parse(string input)
        {
            string[] numberInput;
            bool hasCustomDelimiter = input.StartsWith("//");

            if (hasCustomDelimiter)
            {
                string delimitersInput = input.Substring(2, input.IndexOf("\n") - 2);
                input = input.Substring(input.IndexOf("\n") + 1);
                string[] customDelimiters = { delimitersInput };
                string[] delimiters = _defaultDelimiters.Union(customDelimiters).ToArray();
                numberInput = input.Split(delimiters, StringSplitOptions.None);
            }
            else
            {
                numberInput = input.Split(_defaultDelimiters, StringSplitOptions.None);
            }
            return numberInput; 
        }
    }
}

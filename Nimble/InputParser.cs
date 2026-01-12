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
            int indexOfEOL = input.IndexOf("\n");
            bool hasCustomDelimiter = input.StartsWith("//") && indexOfEOL == 3;
            bool hasCustomLongDelimiter = input.StartsWith("//[");
            string delimiterInput = string.Empty;

            if (hasCustomDelimiter)
            {
                delimiterInput = input.ElementAt(2).ToString();
                input = input.Substring(4);
            }

            if (hasCustomLongDelimiter)
            {
                delimiterInput = input.Substring(3, indexOfEOL - 4);
                input = input.Substring(indexOfEOL + 1);
            }

            if (hasCustomDelimiter || hasCustomLongDelimiter)
            {
                string[] customDelimiters = { delimiterInput };
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

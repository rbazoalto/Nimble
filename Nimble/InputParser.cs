using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public class InputParser
    {
        public static readonly string[] _delimiters = new string[] { ",", "\n" };

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
            return input.Split(_delimiters, StringSplitOptions.None); 
        }
    }
}

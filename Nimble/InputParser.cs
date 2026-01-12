using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public class InputParser
    {
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
            string[] parameters = input.Split(',');
            if (parameters.Length > 2)
            {
                throw new ArgumentException("More than 2 parameters were set in the input: " + input);
            }
            return parameters;
        }
    }
}

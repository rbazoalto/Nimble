using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public class Calculator : ICalculator
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

        /// <summary>
        /// Returns the Multiplication of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <returns>The multiplication of the numbers.</returns>
        public int Multiply(List<int> numbers)
        {
            int res = 1;
            foreach (var item in numbers)
            {
                res *= item;
            }

            return res;
        }

        /// <summary>
        /// Returns the Multiplication of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <param name="message">The formatted operation like 1*2</param>
        /// <returns>The multiplication of the numbers</returns>
        public int Multiply(List<int> numbers, out string message)
        {
            int res = 1;
            string operation = string.Empty;

            foreach (var item in numbers)
            {
                res *= item;
                operation = operation + item + "*";
            }

            message = operation.Remove(operation.Length - 1) + " = " + res;
            return res;
        }

        /// <summary>
        /// Returns the Substraction of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <returns>The Substraction of the first number against the other numbers.</returns>
        public int Substract(List<int> numbers)
        {
            int res = 0;
            int index = 0;
            foreach (var item in numbers)
            {
                if (index == 0)
                {
                    res = item;
                    index++;
                    continue;
                }
                res -= item;
            }

            return res;
        }

        /// <summary>
        /// Returns the Substraction of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <param name="message">The formatted operation like 1-2</param>
        /// <returns>The substraction of the first number against the other numbers</returns>
        public int Substract(List<int> numbers, out string message)
        {
            int res = 0;
            string operation = string.Empty;
            int index = 0;

            foreach (var item in numbers)
            {
                if (index == 0)
                {
                    res = item;
                    index++;
                    operation = item + "-";
                    continue;
                }
                res -= item;
                operation = operation + item + "-";
            }

            message = operation.Remove(operation.Length - 1) + " = " + res;
            return res;
        }

        /// <summary>
        /// Returns the Division of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <returns>The division of the numbers.</returns>
        public double Divide(List<int> numbers)
        {
            double res = 0;
            int index = 0;
            foreach (var item in numbers)
            {
                if (index == 0)
                {
                    res = item;
                    index++;
                    continue;
                }
                // let's skip zero dividers
                if (item != 0)
                {
                    res /= (double) item;
                }
            }

            return res;
        }

        /// <summary>
        /// Returns the Division of the numbers
        /// </summary>
        /// <param name="numbers">A list of numbers</param>
        /// <param name="message">The formatted operation like 1/2</param>
        /// <returns>The division of the first number against the other numbers</returns>
        public double Divide(List<int> numbers, out string message)
        {
            double res = 0;
            string operation = string.Empty;
            int index = 0;

            foreach (var item in numbers)
            {
                if (index == 0)
                {
                    res = item;
                    index++;
                    operation = item + "/";
                    continue;
                }
                // let's skip zero dividers
                if (item != 0)
                {
                    res /= (double) item;
                    operation = operation + item + "/";
                }
            }

            message = operation.Remove(operation.Length - 1) + " = " + res;
            return res;
        }
    }
}

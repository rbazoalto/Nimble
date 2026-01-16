using System;
using System.Collections.Generic;
using System.Text;

namespace Nimble
{
    public interface ICalculator
    {
        public int Sum(List<int> numbers);
        public int Sum(List<int> numbers, out string message);
        public int Multiply(List<int> numbers);
        public int Multiply(List<int> numbers, out string message);
        public int Substract(List<int> numbers);
        public int Substract(List<int> numbers, out string message);
        public double Divide(List<int> numbers);
        public double Divide(List<int> numbers, out string message);
    }
}

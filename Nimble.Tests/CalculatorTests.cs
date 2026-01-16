using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nimble;

namespace Nimble.Tests
{
    class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IfInputCleanReturnsCorrectSum()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> {1,2};
            int expectedResult = 3;

            // Test
            int result = calculator.Sum(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfInputCleanReturnsCorrectSumAndMessage()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 1, 2 };
            string message = string.Empty;
            string expectedMessage = "1+2 = 3";

            // Test
            int result = calculator.Sum(input, out message);

            // Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [Test]
        public void IfInputCleanReturnsCorrectMultiplication()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 4, 2 };
            int expectedResult = 8;

            // Test
            int result = calculator.Multiply(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfInputCleanReturnsCorrectMultiplicationAndMessage()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 4, 2 };
            string message = string.Empty;
            string expectedMessage = "4*2 = 8";

            // Test
            int result = calculator.Multiply(input, out message);

            // Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [Test]
        public void IfInputCleanReturnsCorrectSubstraction()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 5, 2 };
            int expectedResult = 3;

            // Test
            int result = calculator.Substract(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfInputCleanReturnsCorrectSubstractionAndMessage()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 5, 2 };
            string message = string.Empty;
            string expectedMessage = "5-2 = 3";

            // Test
            int result = calculator.Substract(input, out message);

            // Assert
            Assert.AreEqual(expectedMessage, message);
        }

        [Test]
        public void IfInputCleanReturnsCorrectDivision()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 10, 4 };
            double expectedResult = 2.5;

            // Test
            double result = calculator.Divide(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfInputCleanReturnsCorrectDivisionAndMessage()
        {
            // Configure
            Calculator calculator = new Calculator();
            List<int> input = new List<int> { 10, 4 };
            string message = string.Empty;
            string expectedMessage = "10/4 = 2.5";

            // Test
            double result = calculator.Divide(input, out message);

            // Assert
            Assert.AreEqual(expectedMessage, message);
        }
    }
}

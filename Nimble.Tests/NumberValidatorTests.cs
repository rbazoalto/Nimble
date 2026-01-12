using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nimble;

namespace Nimble.Tests
{
    class NumberValidatorTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IfParametersInputReturnsListOfNumbers()
        {
            // Configure
            NumberValidator validator = new NumberValidator();
            string[] input = new string[] {"1", "2" };
            List<int> expectedResult = new List<int> { 1, 2 };

            // Test
            List<int> result = validator.Validate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfParametersInputWithNonNumbersReturnsListOfNumbersUsingZeros()
        {
            // Configure
            NumberValidator validator = new NumberValidator();
            string[] input = new string[] { "1", "h" };
            List<int> expectedResult = new List<int> { 1, 0 };

            // Test
            List<int> result = validator.Validate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfParametersInputWithBigNumbersReturnsListOfNumbersWithZeros()
        {
            // Configure
            NumberValidator validator = new NumberValidator();
            string[] input = new string[] { "1", "2", "1001" };
            List<int> expectedResult = new List<int> { 1, 2, 0 };

            // Test
            List<int> result = validator.Validate(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfParametersInputWithCustomUpperBoundReturnsListOfNumbersWithZeros()
        {
            // Configure
            NumberValidator validator = new NumberValidator();
            string[] input = new string[] { "1", "2", "301" };
            List<int> expectedResult = new List<int> { 1, 2, 0 };
            int upperBound = 300;

            // Test
            List<int> result = validator.Validate(input, upperBound);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfNegativeParametersWithFlagFalseReturnsListOfNumbers()
        {
            // Configure
            NumberValidator validator = new NumberValidator();
            string[] input = new string[] { "1", "-2", "5" };
            List<int> expectedResult = new List<int> { 1, -2, 5 };
            int upperBound = 300;
            bool denyNegativeNumbers = false;

            // Test
            List<int> result = validator.Validate(input, upperBound, denyNegativeNumbers);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

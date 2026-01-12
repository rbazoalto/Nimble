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
    }
}

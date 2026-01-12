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

            // Test
            int result = calculator.Sum(input);

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}

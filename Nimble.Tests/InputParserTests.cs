using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Nimble;

namespace Nimble.Tests
{
    class InputParserTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GivenInputReturnsListOfParameters()
        {
            // Configure
            InputParser parser = new InputParser();
            string input = "1,2";
            string[] expectedResult = new string[] { "1" , "2"};

            // Test
            string[] result = parser.Parse(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

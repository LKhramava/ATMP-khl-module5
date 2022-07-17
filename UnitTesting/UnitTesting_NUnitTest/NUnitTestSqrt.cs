using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestSqrt
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(81, 9)]
        [TestCase(-81, double.NaN)]
        [TestCase(0.09, 0.3)]
        [TestCase(-0, 0)]
        [TestCase(0, 0)]
        [TestCase("81", 9)]
        [TestCase("-81", double.NaN)]
        [TestCase("0.09", 0.3)]
        [TestCase("-0", 0)]
        [TestCase("0", 0)]
        public void VerifySqrtForCorrectValues(object input, double expectedResult)
        {
            var actualResult = _calculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void VerifyIncorrectInput()
        {
            Assert.Throws<FormatException>(() => _calculator.Sqrt("test1"));
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }
}


using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestPow
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(8, 2, 64)]
        [TestCase(2.5, 3, 15.625)]
        [TestCase(202, 4, 1664966416)]
        [TestCase(0, -2, double.PositiveInfinity)]
        [TestCase(0, 2, 0)]
        [TestCase(1, 1000, 1)]
        [TestCase("8", "2", 64)]
        [TestCase("2.5", "3", 15.625)]
        [TestCase("202", "4", 1664966416)]
        [TestCase("0", "-2", double.PositiveInfinity)]
        [TestCase("0", "2", 0)]
        [TestCase("1", "1000", 1)]
        public void VerifyPowForCorrectValues(object input, object power, double expectedResult)
        {
            var actualResult = _calculator.Pow(input, power);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void VerifyIncorrectInput()
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Pow("test1", "test2"));
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }
}



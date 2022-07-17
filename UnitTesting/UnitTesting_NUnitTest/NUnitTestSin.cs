using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestSin
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(30, 0.5)]
        [TestCase(90, 1)]
        [TestCase(180, 0)]
        [TestCase(270, -1)]
        [TestCase(360, 0)]
        [TestCase("30", 0.5)]
        [TestCase("90", 1)]
        [TestCase("180", 0)]
        [TestCase("270", -1)]
        [TestCase("360", 0)]
        public void VerifySinForCorrectValues(object input, double expectedResult)
        {
            double inputInRadians = (Convert.ToDouble(input) * (Math.PI)) / 180;
            
            var actualResult = _calculator.Sin(inputInRadians);
            actualResult = Math.Round(actualResult, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void VerifyIncorrectInput()
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Sin("test1"));
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }
}




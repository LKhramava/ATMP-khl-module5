using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestAdd
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(3, 4, 7)]
        [TestCase(11.7, 2.3, 14)]
        [TestCase(-120, -5, -125)]
        [TestCase(7, -7, 0)]
        [TestCase(double.MaxValue, 10, double.MaxValue)]
        [TestCase("3", "4", 7)]
        [TestCase("11.7", "2.3", 14)]
        [TestCase("-120", "-5", -125)]
        [TestCase("7", "-7", 0)]
        public void VerifyAdditionTwoDoubles(object firstInput, object secondInput, double expectedResult)
        {
            var actualResult = _calculator.Add(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void VerifyAdditionIncorrectTwoInputs()
        {
            var actualResult = _calculator.Add("test1", "test2");
            Assert.Throws<InvalidCastException>(() => _calculator.Add("test1", "test2"));
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }
}

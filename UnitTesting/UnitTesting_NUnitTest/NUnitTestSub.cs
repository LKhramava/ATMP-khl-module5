using CSharpCalculator;
using NUnit.Framework;
using System;

[assembly:LevelOfParallelism(2)]

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestSub
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(4, 3, 1)]
        [TestCase(12.7, 2.3, 10.4)]
        [TestCase(-125, -5, -120)]
        [TestCase(-7, -7, 0)]
        [TestCase(double.MaxValue, 10, double.MaxValue)]
        [TestCase("4", "3", 1)]
        [TestCase("12.7", "2.3", 10.4)]
        [TestCase("-125", "-5", -120)]
        [TestCase("-7", "-7", 0)]
        public void VerifySubTwoDoubles(object firstInput, object secondInput, double expectedResult)
        {
            var actualResult = _calculator.Sub(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void VerifySubIncorrectTwoInputs()
        {
            Assert.Throws<InvalidCastException>(() => _calculator.Sub("test1", "test2"));
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }
}

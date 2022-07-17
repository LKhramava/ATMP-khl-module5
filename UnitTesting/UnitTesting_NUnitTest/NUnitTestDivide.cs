using CSharpCalculator;
using NUnit.Framework;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestDivide
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(4, 4, 1)]
        [TestCase(8.28, 2.3, 3.6)]
        [TestCase(-300, -5, 60)]
        [TestCase(7, -7, -1)]
        [TestCase(0, 3, 0)]
        [TestCase(3, 0, double.PositiveInfinity)]
        public void VerifyDivideTwoDoubles(double firstInput, double secondInput, double expectedResult)
        {
            var actualResult = _calculator.Divide(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

    }

}

using CSharpCalculator;
using NUnit.Framework;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.All)]
    public class NUnitTestIsNegative
    {
        private static Calculator _calculator = new Calculator();

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
        }

        [Test]
        [TestCase(10, false)]
        [TestCase(-10, true)]
        [TestCase(10.5, false)]
        [TestCase(-10.5, true)]
        [TestCase("10", false)]
        [TestCase("-10", true)]
        [TestCase("10.5", false)]
        [TestCase("-10.5", true)]
        public void VerifyIsNegativeForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }

        //[ClassCleanup]
        //public static void ClassClean()
        //{
        //    //post conditions for class
        //}
    }
}




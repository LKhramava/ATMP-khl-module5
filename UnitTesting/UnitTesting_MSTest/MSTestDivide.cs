using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestDivide
    {
        private static Calculator _calculator = new Calculator();

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //preconditions for class
        }

        [TestInitialize]
        public void TestInit()
        {
            //preconditions for test
        }

        [TestMethod]
        [DataRow(4, 4, 1)]
        [DataRow(8.28, 2.3, 3.6)]
        [DataRow(-300, -5, 60)]
        [DataRow(7, -7, -1)]
        [DataRow(0, 3, 0)]
        [DataRow(3, 0, double.PositiveInfinity)]
        public void VerifyDivideTwoDoubles(double firstInput, double secondInput, double expectedResult)
        {
            var actualResult = _calculator.Divide(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void TestClean()
        {
            //post conditions for test
        }

        [ClassCleanup]
        public static void ClassClean()
        {
            //post conditions for class
        }
    }

}

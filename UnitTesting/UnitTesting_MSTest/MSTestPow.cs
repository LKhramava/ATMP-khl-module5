using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestPow
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
        [DataRow(8, 2, 64)]
        [DataRow(2.5, 3, 15.625)]
        [DataRow(202, 4, 1664966416)]
        [DataRow(0, -2, double.PositiveInfinity)]
        [DataRow(0, 2, 0)]
        [DataRow(1, 1000, 1)]
        [DataRow("8", "2", 64)]
        [DataRow("2.5", "3", 15.625)]
        [DataRow("202", "4", 1664966416)]
        [DataRow("0", "-2", double.PositiveInfinity)]
        [DataRow("0", "2", 0)]
        [DataRow("1", "1000", 1)]
        public void VerifyPowForCorrectValues(object input, object power, double expectedResult)
        {
            var actualResult = _calculator.Pow(input, power);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotFiniteNumberException))]
        public void VerifyIncorrectInput()
        {
            _calculator.Abs("test1");
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



using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestIsNegative
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
        [DataRow(10, false)]
        [DataRow(-10, true)]
        [DataRow(10.5, false)]
        [DataRow(-10.5, true)]
        [DataRow("10", false)]
        [DataRow("-10", true)]
        [DataRow("10.5", false)]
        [DataRow("-10.5", true)]
        public void VerifyIsNegativeForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isNegative(input);
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




using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestIsPositive
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
        [DataRow(10, true)]
        [DataRow(-10, false)]
        [DataRow(10.5, true)]
        [DataRow(-10.5, false)]
        [DataRow("10", true)]
        [DataRow("-10", false)]
        [DataRow("10.5", true)]
        [DataRow("-10.5", false)]
        public void VerifyIsPositiveForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isPositive(input);
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




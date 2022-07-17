using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestSub
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
        [DataRow(4, 3, 1)]
        [DataRow(12.7, 2.3, 10.4)]
        [DataRow(-125, -5, -120)]
        [DataRow(-7, -7, 0)]
        [DataRow(double.MaxValue, 10, double.MaxValue)]
        [DataRow("4", "3", 1)]
        [DataRow("12.7", "2.3", 10.4)]
        [DataRow("-125", "-5", -120)]
        [DataRow("-7", "-7", 0)]
        public void VerifySubTwoDoubles(object firstInput, object secondInput, double expectedResult)
        {
            var actualResult = _calculator.Sub(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotFiniteNumberException))]
        public void VerifySubIncorrectTwoInputs()
        {
            _calculator.Sub("test1", "test2");
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

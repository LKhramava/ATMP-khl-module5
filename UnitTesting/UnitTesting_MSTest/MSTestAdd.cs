using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestAdd
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
        [DataRow(3, 4, 7)]
        [DataRow(11.7, 2.3, 14)]
        [DataRow(-120, -5, -125)]
        [DataRow(7, -7, 0)]
        [DataRow(double.MaxValue, 10, double.MaxValue)]
        [DataRow("3", "4", 7)]
        [DataRow("11.7", "2.3", 14)]
        [DataRow("-120", "-5", -125)]
        [DataRow("7", "-7", 0)]
        public void VerifyAdditionTwoDoubles(object firstInput, object secondInput, double expectedResult)
        {
            var actualResult = _calculator.Add(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidCastException))]
        public void VerifyAdditionIncorrectTwoInputs()
        {
            _calculator.Add("test1", "test2");
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

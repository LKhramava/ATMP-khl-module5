using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestAbs
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
        [DataRow(-123, 123)]
        [DataRow(123, 123)]
        [DataRow(-12.3, 12.3)]
        [DataRow(-12.7, 12.7)]
        [DataRow(12.3, 12.3)]
        [DataRow(0, 0)]
        [DataRow("-123", 123)]
        [DataRow("123", 123)]
        [DataRow("-12.3", 12.3)]
        [DataRow("12.3", 12.3)]
        public void VerifyAbsForCorrectValues(object input, double expectedAbs)
        {
            var valueAbs = _calculator.Abs(input);
            Assert.AreEqual(expectedAbs, valueAbs);
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

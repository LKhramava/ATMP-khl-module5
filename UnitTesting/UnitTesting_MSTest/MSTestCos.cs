using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestCos
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
        [DataRow(0, 1)]
        [DataRow(60, 0.5)]
        [DataRow(90, 0)]
        [DataRow(270, 0)]
        [DataRow(360, 1)]
        [DataRow("0", 1)]
        [DataRow("60", 0.5)]
        [DataRow("90", 0)]
        [DataRow("270", 0)]
        [DataRow("360", 1)]
        public void VerifyCosForCorrectValues(object input, double expectedResult)
        {
            double inputInRadians = (Convert.ToDouble(input) * (Math.PI)) / 180;
            
            var actualResult = _calculator.Cos(inputInRadians);
            actualResult = Math.Round(actualResult, 1);
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




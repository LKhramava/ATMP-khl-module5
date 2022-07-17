using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestSin
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
        [DataRow(30, 0.5)]
        [DataRow(90, 1)]
        [DataRow(180, 0)]
        [DataRow(270, -1)]
        [DataRow(360, 0)]
        [DataRow("30", 0.5)]
        [DataRow("90", 1)]
        [DataRow("180", 0)]
        [DataRow("270", -1)]
        [DataRow("360", 0)]
        public void VerifySinForCorrectValues(object input, double expectedResult)
        {
            double inputInRadians = (Convert.ToDouble(input) * (Math.PI)) / 180;
            
            var actualResult = _calculator.Sin(inputInRadians);
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




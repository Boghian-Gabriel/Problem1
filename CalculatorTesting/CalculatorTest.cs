using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTesting
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Divide()
        {
            //1. Arrange = initializez objects and set the value of the data
            // that is passed to the method being tested
            int expected = 10;
            int numerator = 100;
            int denominator = 10;
            
            //2. Act = invokes the method being tested
            int actual = Calculator.Program.Divide(numerator, denominator);
            
            //3. Asset = verifies that the method being tested
            //         behaves as expected
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_PozNumeratorAndNegativeDenominator_ReturnsNegativeQuotient()
        {
            // Arrange
            int expected = -10;
            int numerator = 100;
            int denominator = -10;
            // Act
            int actual = Calculator.Program.Divide(numerator, denominator);
            // Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Divide_NegativeNumber_ReturnPositiveQuotient()
        {
            // Arrange
            int expected = 10;
            int numerator = -100;
            int denominator = -10;
            // Act
            int actual = Calculator.Program.Divide(numerator , denominator);
            // Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Try to divide numerator by zero")]
        public void Divide_DenominatorIsZero_ThrowDivideByZeroException()
        {
            // Arrange   
            int except = 0;
            int numerator = 100;
            int denominator = 0;
            // Act            

            int result = Calculator.Program.Divide(numerator, denominator);
            
            //Assert
            Assert.AreEqual(except, result);
            /*
             We can run the unit test in several ways,
            1. Run all test
            2. Run single test
            3. Run all test for the only selected test class.
             */
        }
    }
}

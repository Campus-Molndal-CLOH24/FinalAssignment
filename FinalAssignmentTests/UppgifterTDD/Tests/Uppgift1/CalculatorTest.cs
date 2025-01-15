using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment.UppgifterTDD.Uppgift1;

namespace FinalAssignmentTest.Tests.Uppgift1
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        #region ADDITION TESTS

        [TestMethod]
        public void AddFromInput_ValidNumbers_ReturnsCorrectSum()
        {
            AssertSum("4", "5", 9.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFromInput_InvalidNumbers_ThrowsArgumentException()
        {
            _calculator.AddFromInputWithValidation("abc", "5.5");
        }

        private void AssertSum(string inputA, string inputB, double expectedSum)
        {
            var actualSum = _calculator.AddFromInput(inputA, inputB);
            Assert.AreEqual(expectedSum, actualSum);
        }

        //NEW TESTS FOR ADDITION

        [TestMethod]
        public void AddNegativePositive()
        {
            // Arrange
            var inputA = "-4";
            var inputB = "5";
            var expectedSum = 1.0;

            // Act
            var actualSum = _calculator.AddNegativePositive(inputA, inputB);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }




        #endregion

        #region DIVISION TESTS

        [TestMethod]
        public void DivideFromInput_ValidNumbers_ReturnsCorrectQuotient()
        {
            AssertQuotient("10", "2", 5.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideFromInput_InvalidNumbers_ThrowsArgumentException()
        {
            _calculator.DivideFromInput("abc", "5.5");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideFromInput_DivideByZero_ThrowsArgumentException()
        {
            _calculator.DivideFromInput("10", "0");
        }

        private void AssertQuotient(string inputA, string inputB, double expectedQuotient)
        {
            var actualQuotient = _calculator.DivideFromInput(inputA, inputB);
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [TestMethod]
        public void DivideNegativePositive()
        {
            // Arrange
            var inputA = "-10";
            var inputB = "2";
            var expectedQuotient = -5.0;

            // Act
            var actualQuotient = _calculator.DivideFromInput(inputA, inputB);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        #endregion

        #region MULTIPLICATION TESTS

        [TestMethod]
        public void MultiplyFromInput_ValidNumbers_ReturnsCorrectProduct()
        {
            AssertProduct("4", "5", 20.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MultiplyFromInput_InvalidNumbers_ThrowsArgumentException()
        {
            _calculator.MultiplyFromInput("abc", "5.5");
        }

        private void AssertProduct(string inputA, string inputB, double expectedProduct)
        {
            var actualProduct = _calculator.MultiplyFromInput(inputA, inputB);
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        #endregion

        #region SUBTRACTION TESTS

        [TestMethod]
        public void SubstractFromInput_ValidNumbers_ReturnsCorrectDifference()
        {
            AssertDifference("10", "2", 8.0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SubstractFromInput_InvalidNumbers_ThrowsArgumentException()
        {
            _calculator.SubstractFromInput("abc", "5");
        }

        private void AssertDifference(string inputA, string inputB, double expectedDifference)
        {
            var actualDifference = _calculator.SubstractFromInput(inputA, inputB);
            Assert.AreEqual(expectedDifference, actualDifference);
        }
    }
}


#endregion




















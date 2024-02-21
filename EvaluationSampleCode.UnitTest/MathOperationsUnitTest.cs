namespace EvaluationSampleCode.UnitTest;

[TestClass]
public class MathOperationsTest
{
    private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(5, 3, 2)]
        [DataRow(10, 6, 4)]
        public void Substract_WithTwoNumbers_ReturnsSubstraction(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Subtract(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(3,11)]
        [DataRow(5, 2500)]
        public void Substract_WithSecondNumberHigherThanFirst_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(2, "Red")]
        [DataRow(3, "Blue")]
        public void GetColorFromOddsNumber_WithCorrectOddsNumber_ReturnsColor(int number, string expectedResult)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(3, "Red")]
        [DataRow(2, "Blue")]
        public void GetColorFromOddsNumber_WithIncorrectOddsNumber_ReturnsColor(int number, string expectedResult)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);

            Assert.AreNotEqual(expectedResult, result);
        }


}

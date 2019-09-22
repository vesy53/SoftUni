namespace MySpecialApp.Tests
{
    using MyTestingFramework.Asserts;
    using MyTestingFramework.Attributes;

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod()]
        public void ShouldSumSuccessfullyTwoValues()
        {
            // arrange
            int a = 10;
            int b = 20;
            int expectedResult = 30;

            // act
            Calculator calculator = new Calculator();

            int actualResult = calculator.Sum(a, b);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldDivideSuccessfullyTwoValues()
        {
            // arrange
            int a = 10;
            int b = 10;
            int expectedResult = 1;

            // act
            Calculator calculator = new Calculator();
            int actualResult = calculator.Divide(a, b);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
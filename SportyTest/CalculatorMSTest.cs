using Sporty;

namespace SportyTest
{
    [TestClass]
    public class CalculatorMSTest
    {
        [TestMethod]
        public void AddNumber_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Caculator calc = new();

            //Act
            int result = calc.AddNumber(10, 20);
            
            //Assert
            Assert.AreEqual(30, result);
        }
    }
}
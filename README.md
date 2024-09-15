This learning example with real world project impact me the deep knowledge about Testing in software development world, the benefits of writing unit tests are huge. I think that most of the recently started projects contain any unit tests. In enterprise applications with a lot of business logic, unit tests are the most important tests, because they are fast and can  instantly assure that our implementation is correct. However, I often see a problem with good tests in projects, though these tests' benefits are only huge when you have good unit tests. So in these examples, I get to acquired good knowledge of it.

Example i created a class
public class Caculator
{
    public List<int> NumberRange = new();
    public int AddNumber(int a, int b)
    {
        return a + b;
        
    }

    public double AddDoubleNumber(double a, double b)
    {
        return a + b;

    }
    public bool isOddNumber(int a)
    {
        return a % 2 != 0;

    }
}
I now i test it using UnitTest and i can assure your that syntax between UnitTest, MSTest, XUnitTest and not much different

  [TestFixture]
  public class CalculatorNUnitTests
  {
      [Test]
      public void AddNumber_InputTwoInt_GetCorrectAddition()
      {
          //Arrange
          Caculator calc = new();

          //Act
          int result = calc.AddNumber(10, 20);

          //Assert
          Assert.AreEqual(30, result);
      }

      [Test]
      public void isOddChecker_InputEvenNumber_ReturnFalse()
      {
          //Arrange
          Caculator calc = new();

          //Act
         bool result = calc.isOddNumber(10);

          //Assert
          Assert.That(result, Is.EqualTo(false));
          Assert.IsFalse(result);
      }

      [Test]
      [TestCase(11)]
      [TestCase(13)]
      public void isOddChecker_InputOffNumber_ReturnTrue(int a)
      {
          //Arrange
          Caculator calc = new();

          //Act
          bool result = calc.isOddNumber(a);

          //Assert
          Assert.That(result, Is.EqualTo(true));
          Assert.IsTrue(result);
      }

      [Test]
      [TestCase(10, ExpectedResult = false)]
      [TestCase(11, ExpectedResult = true)]
      public bool isOddChecker_InputNumber_ReturnNumberOfOdd(int a)
      {
          //Arrange
          Caculator calc = new();

          //Act
          return calc.isOddNumber(a);

          //Assert
         
      }
}

In the example i use Visual Studio as IDE 

--
Use libraries such as 
MOQ - to mock some testing especially when i initialize my interface,
EntityFrameworkCore - to for creating our server side,
SQL - to store our details. 
S.O.L.I.D - architecture.

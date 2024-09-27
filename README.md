# Sparky_AspDotNet_Testing
Welcome to the Sparky_AspDotNet_Testing studies plus real world project! This application focuses on unit testing using .NET C#, employing NUnit Testing, Microsoft Testing and XUnit Testing frameworks alongside Moq for mocking dependencies. It follows SOLID principles and utilizes Entity Framework Core for data access.

## Features
* Unit Testing: Comprehensive tests for key components using NUnit.
* Mocking with Moq: Efficiently simulate dependencies for isolated tests.
* Authentication Testing: Validate security features and user authentication flows.
* Entity Framework Core: Test data access logic with an emphasis on performance and reliability.

## Tech Stack
* Backend: .NET Core, C#
* Testing Frameworks: NUnit, Microsoft Testing
* Mocking Library: Moq
* ORM: Entity Framework Core

## Key Concepts
* SOLID Principles: Ensures maintainable and scalable code architecture.
* Unit Testing: Focus on individual components for accurate and efficient testing.
* Mocking: Use of Moq to create mock objects for dependency isolation.

# Getting Started
Clone the repository.
Restore NuGet packages.
Run the tests using your preferred testing framework.
For detailed setup instructions, check the [Github](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)


##Few sample of the code examples: 
```public class Caculator
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
```
Contributing
Contributions are welcome! Please submit a pull request or open an issue for enhancements or suggestions.

Happy testing! 🧪✨


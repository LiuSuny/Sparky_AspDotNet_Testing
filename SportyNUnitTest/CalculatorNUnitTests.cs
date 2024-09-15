using NUnit.Framework;
using Sporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportyNUnitTest
{
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

        [Test]
        [TestCase(10.4, 5.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddDoubleNumber_InputTwoInt_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Caculator calc = new();

            //Act
            double result = calc.AddDoubleNumber(a, b);

            //Assert
            Assert.AreEqual(15.9, result, .2);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            Caculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            //act
            List<int> result = calc.GetOddRange(5, 10);

            //Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            //Assert.AreEqual( expectedOddRange, result);
            //Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }

    }
}

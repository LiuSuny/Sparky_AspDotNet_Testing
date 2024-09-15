using Sporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SportyXUnitTest
{
    public class CustomerXUnitTests
    {
        private Customer customer;
        public CustomerXUnitTests()
        {
            customer = new Customer();
        }

        //        [Test]
        //        public void CombineName_InputFirstAndLastName_ReturnFullName()
        //        {
        //            //Arrange
        [Fact]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange

            //            //Act
            //            customer.GreetAndCombineNames("Ben", "Spark");
            //            Assert.Multiple(() =>
            //            {
            //                Assert.AreEqual(customer.GreetMessage, "Hello, Ben Spark");
            //                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            //                Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase);
            //                Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
            //                Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
            //                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            //            });
            //            //Assert
            //Act
            customer.GreetAndCombineNames("Ben", "Spark");

            //        }
            Assert.Equal("Hello, Ben Spark", customer.GreetMessage);
            Assert.Contains("ben Spark".ToLower(), customer.GreetMessage.ToLower());
            Assert.StartsWith("Hello,", customer.GreetMessage);
            Assert.EndsWith("Spark", customer.GreetMessage);

            //        [Test]
            //        public void GreetMessage_NotGreeted_ReturnsNull()
            //        {
            //            //arrange
            Assert.Matches("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", customer.GreetMessage);
            //Assert

            //            //act

            //            //assert
            //            Assert.IsNull(customer.GreetMessage);
            //        }
        }

        //        [Test]
        //        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        //        {
        //            int result = customer.Discount;
        //            Assert.That(result, Is.InRange(10, 25));
        //        }
        [Fact]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //arrange

            //        [Test]
            //        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
            //        {
            //            customer.GreetAndCombineNames("ben","");
            //act

            //            Assert.IsNotNull(customer.GreetMessage);
            //            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
            //        }
            //assert
            Assert.Null(customer.GreetMessage);
        }

        //        [Test]
        //        public void GreetChecker_EmptyFirstName_ThrowsException()
        //        {
        //            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));
        //            Assert.AreEqual("Empty First Name", exceptionDetails.Message);
        [Fact]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = customer.Discount;
            Assert.InRange(result, 10, 25);
        }

        //            Assert.That(() => customer.GreetAndCombineNames("", "spark"), 
        //                Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));
        [Fact]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            customer.GreetAndCombineNames("ben", "");

            Assert.NotNull(customer.GreetMessage);
            Assert.False(string.IsNullOrEmpty(customer.GreetMessage));
        }

        //            Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));

        //            Assert.That(() => customer.GreetAndCombineNames("", "spark"),
        //                Throws.ArgumentException);
        //        }
        [Fact]
        public void GreetChecker_EmptyFirstName_ThrowsException()
        {
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));
            Assert.Equal("Empty First Name", exceptionDetails.Message);

            Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));
        }

        //        [Test]
        //        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        //        {
        //            customer.OrderTotal = 10;
        //            var result = customer.GetCustomerDetails();
        //            Assert.That(result, Is.TypeOf<BasicCustomer>());
        //        }
        [Fact]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.IsType<BasicCustomer>(result);
        }

        //        [Test]
        //        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
        //        {
        //            customer.OrderTotal = 110;
        //            var result = customer.GetCustomerDetails();
        //            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
        //        }
        //    }
        //}
        [Fact]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 110;
            var result = customer.GetCustomerDetails();
            Assert.IsType<PlatinumCustomer>(result);
        }
    }
}

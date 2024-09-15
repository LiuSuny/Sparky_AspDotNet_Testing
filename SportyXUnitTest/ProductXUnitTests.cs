using Moq;
using Sporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SportyXUnitTest
{
    public class ProductXUnitTests
    {
        [Fact]
        public void GetProductPrice_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            Product product = new() { Price = 50 };

            //            var result = product.GetPrice(new Customer() { IsPlatinum = true });
            var result = product.GetPrice(new Customer() { IsPlatinum = true });

            //            Assert.That(result, Is.EqualTo(40));
            //        }
            Assert.Equal(40, result);
        }

        //        [Test]
        //        public void GetProductPriceMOQAbuse_PlatinumCustomer_ReturnPriceWith20Discount()
        //        {
        //            var customer = new Mock<ICustomer>();
        //            customer.Setup(u => u.IsPlatinum).Returns(true);
        [Fact]
        public void GetProductPriceMOQAbuse_PlatinumCustomer_ReturnPriceWith20Discount()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(u => u.IsPlatinum).Returns(true);

            //            Product product = new Product() { Price = 50 };
            Product product = new Product() { Price = 50 };

            //            var result = product.GetPrice(customer.Object);
            var result = product.GetPrice(customer.Object);

            //            Assert.That(result, Is.EqualTo(40));
            //        }
            //    }
            //}
            Assert.Equal(40, result);
        }
    }
}

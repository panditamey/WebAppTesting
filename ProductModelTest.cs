using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationDemo.Models;

namespace WebAppTesting
{
    public class ProductModelTest
    {
        Product product;

        public ProductModelTest()
        {
            product = new Product();
        }

        [Fact]
        public void CanChangePriceForProduct()
        {
            //Arrange
            product = new Product {
                ProductId = 1,
                ProductName = "Kayak",
                Price = 3000,
                ProductCode = "WTR-KYK",
                Description = "Lorem",
                ImageUrl="image.jpg",
                StarRating=3,
                Category="Water"
            };
            //Act
            product.Price = 4000;
            //Assert
            Assert.Equal(4000,product.Price);
        }
    }
}

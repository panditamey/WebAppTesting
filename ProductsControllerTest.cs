using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebApplicationDemo.Controllers;
using WebApplicationDemo.DAO;
using WebApplicationDemo.Models;

namespace WebAppTesting
{
    public class ProductsControllerTest
    {
        ProductController productController;
        Product product;
        Mock<IProductDao> mockDao;

        public ProductsControllerTest()
        {
            mockDao = new Mock<IProductDao>();
            productController = new ProductController(mockDao.Object);
            product = new Product {
                ProductId = 1,
                ProductName = "Kayak",
                Price = 3000,
                ProductCode = "WTR-KYK",
                Description = "Lorem",
                ImageUrl = "image.jpg",
                StarRating = 3,
                Category = "Water"
            };

        }

        [Fact]
        public async void GetProductsReturns200WhenDataAvailable()
        {
            //Arrange
            //Setup Mock Object To Invoke The Repositories GetAllProducts
            mockDao.Setup(x => x.GetProducts()).Returns(MockGetProducts(1));

            //Act
            var response = await productController.GetProducts();
            Assert.IsType<OkObjectResult>(response.Result);
        }

        public async Task<List<Product>> MockGetProducts(int num)
        {
            List<Product> products = new List<Product>();
            if(num > 0)
            {
                products.Add(product);
            }
            return await Task.FromResult(products);
        }
    }
}

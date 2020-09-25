using System;
using ACM.BL;
using ACM.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest.RepositoryTests.cs
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void RetriveValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "chips",
                Description = "bag of chips description",
                CurrentPrice = 15.96M
            };
        

            //Act
            var actual = productRepository.Retrieve(1);

            //Assert 

            Assert.AreEqual(expected.ProductId, actual.ProductId);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}

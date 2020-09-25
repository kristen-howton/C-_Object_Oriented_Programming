using System;
using ACM.BL;
using ACM.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest.RepositoryTests.cs
{
    [TestClass]
    public class OrderRepositoryTests
    {
        [TestMethod]
        public void RetriveOrderTest()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };
            //Act
            var actual = orderRepository.Retrieve(1);

            //Assert 

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}

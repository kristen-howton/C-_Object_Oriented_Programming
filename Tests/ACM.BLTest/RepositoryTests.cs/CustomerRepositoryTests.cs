using System;
using ACM.BL;
using ACM.BL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest.RepositoryTests.cs
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void RetriveValid()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "aperkins@gmail.com",
                FirstName = "Ann",
                LastName = "Perkins"
            };

            //Act
            var actual = customerRepository.Retrieve(1);
           
            //Assert 
 
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}

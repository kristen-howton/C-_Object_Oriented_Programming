using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            //Instance of customer class
            Customer customer = new Customer
            {
                //using object initatior
                FirstName = "Ann",
                LastName = "Perkins"
            };
            string expected = "Perkins, Ann";

            //Act
            string actual = customer.FullName;
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            //Instance of customer class
            Customer customer = new Customer
            {
                LastName = "Perkins"
            };
            string expected = "Perkins";

            //Act
            string actual = customer.FullName;
            //Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                //using object initatior
                FirstName = "Ann"
            };
            string expected = "Ann";

            //Act
            string actual = customer.FullName;
            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}

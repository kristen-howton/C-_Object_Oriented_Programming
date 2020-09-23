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

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Ron";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Leslie";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "April";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);


        }
        [TestMethod]

        public void ValidateValid()
        {
            //arrange
            var customer = new Customer
            {
                LastName = "Perkins",
                EmailAddress = "aperkins@gmail.com"
            };
            var expected = true;

            //act
            var actual = customer.Validate();

            //assert

            Assert.AreEqual(expected, actual);
        }

        public void ValidateInvalidEmail()
        {
            //arrange
            var customer = new Customer
            {
                LastName = "Perkins"
            };
            var expected = false;

            //act
            var actual = customer.Validate();

            //assert

            Assert.AreEqual(expected, actual);
        }

        public void ValdateInvalidLastName()
        {
            //arrange
            var customer = new Customer
            {
                EmailAddress = "aperkins@gmail.com"
            };
            var expected = false;

            //act
            var actual = customer.Validate();

            //assert

            Assert.AreEqual(expected, actual);
        }





    }
}

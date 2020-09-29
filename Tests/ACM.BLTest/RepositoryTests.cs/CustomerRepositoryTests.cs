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

        [TestMethod]
        public void RetriveExistingWithAddress()
        {
           var customerRepository = new CustomerRepository();
           var exepected = new Customer(1)
           {
                   EmailAddress = "aperkins@gmail.com",
                   FirstName = "Ann",
                   LastName = "Perkins",
                   AddressList = new List<Address>()
                   {
                       new Address()
                       {
                            AddressType = 1,
                            StreetLine1 = "111 Fake Address",
                            StreetLine2 = "Apt 3",
                            City = "Pawnee",
                            State = "PA",
                            Country = "Earth",
                            PostalCode = "42101"
                       },
                       new Address()
                       {
                            AddressType = 2,
                            StreetLine1 = "222 Fake Address",
                            City = "Eagleton",
                            State = "PA",
                            Country = "Bad",
                            PostalCode = "37130"
                       },
                       
                   }      

           };
           var actual = customerRepository.Retrieve(1);

           Assert.AreEqual(expected.CustomerId, actual.CustomerId);
           Assert.AreEqual(expected.AddressType, actual.AddressType);
           Assert.AreEqual(expected.StreetLine1, actual.StreetLine1);
           Assert.AreEqual(expected.StreetLine2, actual.StreetLine2);
           Assert.AreEqual(expected.City, actual.City);
           Assert.AreEqual(expected.State, actual.State);
           Assert.AreEqual(expected.Country, actual.Country);
           Assert.AreEqual(expected.PostalCode, actual.PostalCode);

           for (int i = 0; i < 1; i ++)
           {
               Assert.AreEqual(expected.AddressType[i], actual.AddressType[i]).Address;
               Assert.AreEqual(expected.StreetLine1[i], actual.StreetLine1[i]).StreetLine1;
               Assert.AreEqual(expected.StreetLine2[i], actual.StreetLine2[i]).StreetLine2;
               Assert.AreEqual(expected.City[i], actual.City[i]).City;
               Assert.AreEqual(expected.State[i], actual.State[i]).State;
               Assert.AreEqual(expected.Country[i], actual.Country[i]).Country;
               Assert.AreEqual(expected.PostalCode[i], actual.PostalCode[i]).PostalCode;

            
           }
            
        }
            
    }
}

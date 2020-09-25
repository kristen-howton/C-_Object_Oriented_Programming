using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Repositories
{
    class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "111 Fake Address";
                address.StreetLine2 = "Apt 3";
                address.City = "Pawnee";
                address.State = "PA";
                address.Country = "Earth";
                address.PostalCode = "42101";
            }
            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "111 Fake Address",
                StreetLine2 = "Apt 3",
                City = "Pawnee",
                State = "PA",
                Country = "Earth",
                PostalCode = "42101"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "222 Fake Address",
                City = "Eagleton",
                State = "PA",
                Country = "Bad",
                PostalCode = "37130"

            };
            addressList.Add(address);
        }
    }
        
       
}


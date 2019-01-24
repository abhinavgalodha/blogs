using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebuggingJSON
{
    public class Address
    {
        public string AddressLine1 { get;set;}

        public string AddressLine2 { get;set;}

        public string City { get;set;}

        public string State { get;set;}

        public int Zip { get;set;}

        public static Address GetFirstAddress()
        {
            return GetAddress().FirstOrDefault();
        }

        public static List<Address> GetAddress()
        {
            return new List<Address>
            {
                new Address
                {
                    AddressLine1 = "1800 Continental Avenue",
                    City = "Austin",
                    State = "Texas",
                    Zip = 60606
                },
                new Address
                {
                    AddressLine1 = "1800 Continental Avenue",
                    AddressLine2 = "Apt 456",
                    City = "Austin",
                    State = "Texas",
                    Zip = 60606
                }
            };
        }

    }
}

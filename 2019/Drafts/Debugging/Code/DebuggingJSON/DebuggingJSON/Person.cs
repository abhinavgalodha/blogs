using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebuggingJSON
{
    public class Person
    {
        public string FirstName {get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public static IEnumerable<Person> Get()
        {
            return new List<Person>
            {
                new Person
                {
                    FirstName = "Abhinav",
                    LastName = "Galodha",
                    Address = new Address
                    {
                        AddressLine1 = "1800 Continential Avenue",
                        City = "Austin",
                        State = "Texas",
                        Zip = 122
                    }
                },
                new Person
                {
                    FirstName = "Aayan",
                    LastName = "Galodha",
                    Address = new Address
                    {
                        AddressLine1 = "1 Galodha way",
                        City = "Chicago",
                        State = "ILLINOIS",
                        Zip = 606
                    }
                },
            };
        }

    }
}

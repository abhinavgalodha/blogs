using System.Collections.Generic;

namespace DebuggingJSON
{
    public class Person
    {
        public Person()
        {
            
        }

        public Person(string firstName, string lastName, string gender)
        {
            this.FirstName = firstName;
            this.LastName = LastName;
            this.Gender = new Gender(gender);
        }


        public string FirstName { get; set;}

        public string LastName { get; set;}

        public int Age { get; set;}

        public Address Address { get; set; }

        public Gender Gender { get; private set;}

        public static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person ("Aayan", "Galodha", "Male"),
                new Person ("Abhinav", "Galodha", "Male")
            };
        }
    }


    public class Gender 
    {
        // ReSharper disable once InconsistentNaming
        public static readonly Gender Male = new CarrierCode("Male");

        public static readonly Gender Femail = new CarrierCode("Female");

        public string Name { get; private set; }

        public Gender(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }


    }
}

using System.Collections.Generic;

namespace DebuggingJSON
{
    public class Person1
    {
        public Person1()
        {
            
        }

        private Person1(string firstName, string lastName) : this(firstName, string.Empty, lastName)
        {
        }

        private Person1(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person1(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.Age = age;
        }


        public string FirstName { get; }

        public string MiddleName { get;  }

        public string LastName { get; }

        public int Age { get; }

        //public Address Address { get; }

        //public static IEnumerable<Person> GetPersons()
        //{
        //    return new List<Person>
        //    {
        //        new Person1("Aayan", "Galodha", 1),
        //        new Person1("Abhinav", "Galodha")
        //    };
        //}

    }
}

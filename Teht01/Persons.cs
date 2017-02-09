using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Persons 

    {
        // persons collection stores person objects
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add persons to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person GetPersons(int index)
        {
            if (index < persons.Count && index >= 0) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string socialsecuritynumber)
        {
            foreach(Person person in persons)
            {
                // compare two strings
                if (socialsecuritynumber.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null; // person searched not in collection
        }
        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

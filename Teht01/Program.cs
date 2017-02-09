using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (collection)
            Persons myFriends = new Persons();

            // create few Person objects

            Person person1 = new Person { Firstname = "Pete", Lastname = "Kauppine", SocialSecurityNumber = "123456-666A" };
            Person person2 = new Person { Firstname = "Mara", Lastname = "Raksaukko", SocialSecurityNumber = "654321-1234" };
            Person person3 = new Person { Firstname = "Pena", Lastname = "Koira", SocialSecurityNumber = "235323-2542" };

            // add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person
            Person person4 = myFriends.GetPersons(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("There is no person at that position!");
            }
            Console.WriteLine();

            // print collection
            myFriends.PrintData();

            // find person
            string socialsecuritynumber = "123456-666A";
            Console.WriteLine("Find person with social security number: " + socialsecuritynumber);
            Person person5 = myFriends.FindPerson(socialsecuritynumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person with that social security number");
            }

        }
    }
}

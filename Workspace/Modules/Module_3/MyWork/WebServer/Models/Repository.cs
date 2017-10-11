using System.Collections.Generic;
using System.Linq;

namespace WebServer.Models
{
    public class Repository
    {
        private static int counter;
        public static IList<Person> People{get;} = new List<Person>();

        // Find and get the given person
        public static Person GetPersonByID(int id)
        {
            var target = People.SingleOrDefault(p=>p.ID==id);
            return target;
        }

        // Remove given record
        public static void RemovePersonByID(int id)
        {
            var target = People.SingleOrDefault(p=>p.ID==id);
            if (target != null)
                People.Remove(target);
        }

        // Update a person
        public static void ReplacePersonByID(int id, Person person)
        {
            var target = People.SingleOrDefault(p => p.ID == id);
            if (target != null)
            {
                People.Remove(target);
                People.Add(person);
            }

        }

        // Add a person
        public static void AddPerson(Person person)
        {
            person.ID = counter++; // incrementing the value of ID
            People.Add(person);
        }



    }
}
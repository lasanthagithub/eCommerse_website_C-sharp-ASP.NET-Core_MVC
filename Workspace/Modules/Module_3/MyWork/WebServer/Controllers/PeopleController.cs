using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using System.Linq;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        //Get all people as a list
        [HttpGet]
        public Person[] Get()
        {
            return Repository.People.ToArray();
        }

        // Get person by ID
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Repository.GetPersonByID(id);
        }

        // Add new person
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            Repository.AddPerson(person);
        }

        // Replace existing person
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Person person)
        {
            Repository.ReplacePersonByID(id, person);
        }

        // Delete an existing person
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.RemovePersonByID(id);
        }


    }
}
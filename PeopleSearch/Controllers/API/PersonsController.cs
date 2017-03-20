using System;
using System.Linq;
using System.Web.Http;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers.API
{
    public class PersonsController : ApiController
    {
	    private ApplicationDbContext _context;

	    public PersonsController()
	    {
		    _context = new ApplicationDbContext();
	    }

		// GET /api/persons
		/// <summary>
		/// Get a list of people
		/// </summary>
		/// <returns></returns>
	    public IHttpActionResult GetPersons()
	    {
		    var persons = _context.Persons.ToList();
		    return Ok(persons);
	    }

		// GET /api/persons/1
	    public IHttpActionResult GetPerson(int id)
	    {
		    var person = _context.Persons.SingleOrDefault(p => p.Id == id);
			if (person == null)
			{
				return NotFound();
			}

		    return Ok(person);
	    }

		// POST /api/persons
	    [HttpPost]
	    public IHttpActionResult CreatePerson(Person person)
	    {
			person.Added = DateTime.Today;

		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    _context.Persons.Add(person);
		    _context.SaveChanges();
			
		    return Created(new Uri(Request.RequestUri + "/" + person.Id), person);
	    }

		// PUT /api/persons/1
		[HttpPut]
	    public IHttpActionResult UpdatePerson(int id, Person person)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    var personInDb = _context.Persons.SingleOrDefault(p => p.Id == id);

		    if (personInDb == null)
		    {
			    return NotFound();
		    }

		    personInDb.Name = person.Name;
		    personInDb.DateOfBirth = person.DateOfBirth;
		    personInDb.Address = person.Address;
		    personInDb.EmailAddress = person.EmailAddress;
		    personInDb.Interests = person.Interests;

		    _context.SaveChanges();
		    return Ok();
	    }

		// DELETE /api/persons/1
	    [HttpDelete]
	    public IHttpActionResult DeletePerson(int id)
	    {
		    var personInDb = _context.Persons.SingleOrDefault(p => p.Id == id);
		    if (personInDb == null)
		    {
			    return NotFound();
		    }

		    _context.Persons.Remove(personInDb);
		    _context.SaveChanges();

		    return Ok();
	    }
    }

}

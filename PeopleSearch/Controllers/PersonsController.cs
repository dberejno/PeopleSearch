using System;
using System.Linq;
using System.Web.Mvc;
using PeopleSearch.Models;
using PeopleSearch.ViewModels;

namespace PeopleSearch.Controllers
{
    public class PersonsController : Controller
    {
	    private ApplicationDbContext _context;

	    public PersonsController()
	    {
		    _context = new ApplicationDbContext();
	    }

	    protected override void Dispose(bool disposing)
	    {
		    _context.Dispose();
	    }

	    // GET: Persons
        public ActionResult Index()
        {
			//var persons = _context.Persons.Include(p => p.Interests).ToList();
			var persons = _context.Persons.ToList();

			return View("List", persons);
        }

	    public ActionResult New()
	    {
		    return View("PersonForm", new PersonFormViewModel());
	    }

	    public ActionResult Edit(int id)
	    {
		    var personInDb = _context.Persons.SingleOrDefault(p => p.Id == id);
		    if (personInDb == null)
		    {
			    return HttpNotFound();
		    }

			var viewModel = new PersonFormViewModel(personInDb);

		    return View("PersonForm", viewModel);
	    }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(Person person)
	    {
			if (!ModelState.IsValid)
			{
				return View("PersonForm", new PersonFormViewModel(person));
			}

		    if (person.Id == 0)
		    {				
			    person.Added = DateTime.Today;
			    _context.Persons.Add(person);
		    }
		    else
		    {
			    var personInDb = _context.Persons.Single(p => p.Id == person.Id);

			    personInDb.Name = person.Name;
				personInDb.Address = person.Address;
				personInDb.DateOfBirth = person.DateOfBirth;
				personInDb.EmailAddress = person.EmailAddress;
				personInDb.Interests = person.Interests;
			}

		    _context.SaveChanges();
			return RedirectToAction("Index", "Persons");
	    }
    }
}
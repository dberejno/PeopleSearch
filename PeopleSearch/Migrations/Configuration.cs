using PeopleSearch.Models;

namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearch.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearch.Models.ApplicationDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.

			//context.Persons.AddOrUpdate(
			//  p => p.Name,
			//  new Person { Name = "Andrew Peters", Added = DateTime.Now, Address = "some place", DateOfBirth = DateTime.Now, EmailAddress = "Test@gmai.com", Interests = "stuff I like"},
			//  new Person { Name = "Persons 2", Added = DateTime.Now, Address = "some place", DateOfBirth = DateTime.Now, EmailAddress = "Test@gmai.com", Interests = "stuff I like"},
			//  new Person { Name = "Person 3", Added = DateTime.Now, Address = "some place", DateOfBirth = DateTime.Now, EmailAddress = "Test@gmai.com", Interests = "stuff I like"},
			//  new Person { Name = "Person 4 ", Added = DateTime.Now, Address = "some place", DateOfBirth = DateTime.Now, EmailAddress = "Test@gmai.com", Interests = "stuff I like"}
			
			//);

		}
	}
}

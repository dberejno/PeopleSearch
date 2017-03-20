using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PeopleSearch.Models;

namespace PeopleSearch.ViewModels
{
	public class PersonFormViewModel
	{
		public int? Id { get; set; }

		[Required]
		[StringLength(100)]
		[Display(Name = "Full Name")]
		public string Name { get; set; }

		[Required]
		[Display(Name = "Date Of Birth")]
		public DateTime DateOfBirth { get; set; }

		[Required]
		[StringLength(255)]
		public string Address { get; set; }

		[EmailAddress]
		[Display(Name = "Email Address")]
		public string EmailAddress { get; set; }

		public string Interests { get; set; }

		public String PageTitle
		{
			get { return Id != 0 ? "Edit Person" : "New Person"; }
		}

		public PersonFormViewModel()
		{
			Id = 0;
		}

		public PersonFormViewModel(Person person)
		{
			Id = person.Id;
			Name = person.Name;
			DateOfBirth = person.DateOfBirth;
			Address = person.Address;
			EmailAddress = person.EmailAddress;
			Interests = person.Interests;
		}
	}
}
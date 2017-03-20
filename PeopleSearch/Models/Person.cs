using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace PeopleSearch.Models
{
	public class Person
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }
		
		[Required]
		public DateTime DateOfBirth { get; set; }

		[Required]
		[StringLength(255)]
		public string Address { get; set; }

		[EmailAddress]
		public string EmailAddress { get; set; }

		[Required]
		public DateTime Added { get; set; }
		
		public String Interests { get; set; }

		//Picture

		//public String FullName
		//{
		//	get
		//	{
		//		String fullName = String.Empty;
		//		if (FirstName != null)
		//		{
		//			fullName += FirstName + " ";
		//		}
		//		if (MiddleName != null)
		//		{
		//			fullName += MiddleName + " ";
		//		}
		//		if (LastName != null)
		//		{
		//			fullName += LastName;
		//		}

		//		return fullName;
		//	}
		//}

	}
}
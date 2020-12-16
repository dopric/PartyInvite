using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
	public class ContactResponse
	{
		[Required(ErrorMessage = "Full name is required")]
		[Display(Name = "Full Name")]
		public string FullName { get; set; } 
		public DateTime CreatedDateTime { get; set; }= DateTime.Now;
		[Required(ErrorMessage = "Message is required field")]
		[Display(Name ="Message")]
		public string Message { get; set; }
	}
}
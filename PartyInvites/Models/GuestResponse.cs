using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage ="Name is required field")]
		public string Name { get; set; }
		[Required(ErrorMessage ="Email is required field")]
		public string  Email { get; set; }
		public string Phone { get; set; }
		[Required(ErrorMessage ="Response is required")]
		[Display(Name="Invite Response")]
		public bool? WillAttend { get; set; }
	}
}
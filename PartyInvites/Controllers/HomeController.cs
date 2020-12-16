using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index() { return View(); }

		public ActionResult RsvpForm() { return View(); }

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse response)
		{
			if (ModelState.IsValid)
			{
				return View("Thanks", response);
			}
			return View();
		}

		public ActionResult ContactForm()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ContactForm(ContactResponse response)
		{
			if (ModelState.IsValid)
			{
				//try
				//{
				//	WebMail.SmtpServer = "smtp.gmail.com";
				//	WebMail.SmtpPort = 587; // 465 SSL
				//	WebMail.EnableSsl = true;
				//	WebMail.UserName = "opric.danijela@gmail.com";
				//	WebMail.Password = "emi99sgdo";
				//	WebMail.From = "opric.danijela@gmail.com";
				//	WebMail.Send("opric.dragan@gmail.com", "Test WebMail", "Full Name: " + response.FullName + "\nMessage: " + response.Message);
				//}
				//catch  { }
				return View("ContactResponse", response);
			}
			return View(response);
		}
	}
}
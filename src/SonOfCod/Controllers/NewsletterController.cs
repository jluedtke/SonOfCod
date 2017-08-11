using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        SonOfCodContext db = new SonOfCodContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult MailingList()
        {
            return View(db.Recipients.ToList());
        }

        [HttpPost]
        public IActionResult Index(Recipient r)
        {
            if (r.Email == null)
                return RedirectToAction("Index");

            db.Recipients.Add(r);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

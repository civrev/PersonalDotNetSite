using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class ContactController : Controller
    {
        AppDbContext _appDbContext;
        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            Contact model = _appDbContext.Contacts.First();
            ViewBag.Title = "Contact Me";
            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(Contact c2)
        {
            Contact c1 = _appDbContext.Contacts.First();
            c1.AltEmail = c1.AltEmail;
            c1.GitHubLink = c2.GitHubLink;
            c1.LinkedInLink = c2.LinkedInLink;
            c1.PhoneNumber = c2.PhoneNumber;
            c1.DockerLink = c2.DockerLink;
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

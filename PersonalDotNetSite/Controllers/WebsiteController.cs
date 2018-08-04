using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            WebsiteViewModel model = new WebsiteViewModel();
            ViewBag.Title = "About this site";
            return View(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class InteractController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            InteractViewModel model = new InteractViewModel();
            ViewBag.Title = "Play with my code";
            return View(model);
        }
    }
}

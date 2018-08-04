using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class BioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            BioViewModel model = new BioViewModel();
            ViewBag.Title = "About Me";
            return View(model);
        }
    }
}

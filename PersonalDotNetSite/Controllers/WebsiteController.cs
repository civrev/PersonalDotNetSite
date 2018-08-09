using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.Models;
using PersonalDotNetSite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class WebsiteController : Controller
    {

        private readonly IParagraphRepository _repository;

        public WebsiteController(IParagraphRepository pr)
        {
            _repository = pr;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            WebsiteViewModel model = new WebsiteViewModel();
            model.Paragraphs = _repository.getByType("Website");
            ViewBag.Title = "About this site";
            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(Paragraph p)
        {
            Boolean check = _repository.ContainsId(p.Id);

            if (check)
            {
                //update
                _repository.update(p);
            }
            else
            {
                //insert
                _repository.insert(p);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                Boolean check = _repository.ContainsId(id);

                if (check)
                {
                    _repository.delete(id);
                }
            }

            return RedirectToAction("Index");
        }
    }
}

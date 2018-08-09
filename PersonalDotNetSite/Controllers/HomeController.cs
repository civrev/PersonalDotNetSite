using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalDotNetSite.Models;
using PersonalDotNetSite.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalDotNetSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly IParagraphRepository _repository;
        private readonly IProjectsRepositiory _projectsRepo;
        private readonly ISkillsRepository _skillsRepository;

        public HomeController(IParagraphRepository pr, IProjectsRepositiory prr, ISkillsRepository sr)
        {
            _repository = pr;
            _projectsRepo = prr;
            _skillsRepository = sr;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Paragraphs = _repository.getByType("Home");
            int cardCount = 4;
            model.Skills = _skillsRepository.Items.Take(cardCount);
            model.Projects = _projectsRepo.Items.Take(cardCount);

            ViewBag.Title = "Christian Watts - Welcome to my site!";

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

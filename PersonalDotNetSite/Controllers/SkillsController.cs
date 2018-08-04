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
    public class SkillsController : Controller
    {

        private readonly ISkillsRepository _skillsRepository;

        public SkillsController(ISkillsRepository sr)
        {
            _skillsRepository = sr;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            SkillsViewModel model = new SkillsViewModel();
            model.Skills = _skillsRepository.Skills;

            ViewBag.Title = "What I'm good at";
            return View(model);
        }
    }
}

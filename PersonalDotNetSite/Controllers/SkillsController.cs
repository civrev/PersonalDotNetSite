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
        public IActionResult List(string tagsString)
        {

            ViewBag.Title = "What I'm good at";

            SkillsViewModel model = new SkillsViewModel();

            if(string.IsNullOrEmpty(tagsString))
            {
                //if no arg was passed in, get all skills
                model.Skills = _skillsRepository.Items;
            }
            else
            {
                //if tags were passed in, parse the tags
                string[] tags = new string[100];
                string tempTagString = tagsString;
                int index = tagsString.IndexOf("-");
                int pos = 0;

                while (tempTagString.Contains("-"))
                {
                    tags[pos] = tempTagString.Substring(0, index);
                    tempTagString = tempTagString.Substring(index+1);
                    index = tempTagString.IndexOf("-");
                    pos++;
                }

                //all tags are parsed and are now in the tags array
                tags[pos] = tempTagString;

                //at this point we are still grabbing all skills
                model.Skills = _skillsRepository.Items;

            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(Skill skill)
        {
            Boolean check = _skillsRepository.ContainsId(skill.Id);

            if(check)
            {
                //update
                _skillsRepository.update(skill);
            }
            else
            {
                //insert
                _skillsRepository.insert(skill);
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                Boolean check = _skillsRepository.ContainsId(id);

                if (check)
                {
                    _skillsRepository.delete(id);
                }
            }

            return RedirectToAction("List");
        }
    }
}

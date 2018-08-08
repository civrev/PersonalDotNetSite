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
    public class ProjectsController : Controller
    {
        private readonly IProjectsRepositiory _projectsRepo;

        public ProjectsController(IProjectsRepositiory pr)
        {
            _projectsRepo = pr;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //Lists all projects in cards on site
            ViewBag.Title = "What I've done so far";
            ProjectsViewModel model = new ProjectsViewModel();
            model.Projects = _projectsRepo.Projects;
            return View(model);
        }

        public IActionResult Show(int projId)
        {
            //shows a specific project on its own page in detail
            ProjectsViewModel model = new ProjectsViewModel();
            model.DetailedProject = _projectsRepo.getProjectByName(projId);
            return View(model);
        }
    }
}

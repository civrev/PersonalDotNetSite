using PersonalDotNetSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.ViewModels
{
    public class ProjectsViewModel: GeneralViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public Project DetailedProject { get; set; }
    }
}

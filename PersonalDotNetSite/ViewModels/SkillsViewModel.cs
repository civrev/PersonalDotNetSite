using PersonalDotNetSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.ViewModels
{

    public class SkillsViewModel: GeneralViewModel
    {
        public IEnumerable<Skill> Skills { get; set; }
    }
}

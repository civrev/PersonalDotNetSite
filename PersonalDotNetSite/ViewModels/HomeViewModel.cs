using PersonalDotNetSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.ViewModels
{
    public class HomeViewModel: GeneralViewModel
    {
        public IEnumerable<Paragraph> Paragraphs { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Project> Projects { get; set; }
    }
}

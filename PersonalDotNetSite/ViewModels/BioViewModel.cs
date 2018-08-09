using PersonalDotNetSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.ViewModels
{
    public class BioViewModel: GeneralViewModel
    {
        public IEnumerable<Paragraph> Paragraphs { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class Paragraph
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }

        public Paragraph()
        {
            Text = "default sample text here";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class WebsiteFAQ
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public WebsiteFAQ()
        {
            Question = "no question";
            Answer = "no answer";
        }
    }
}

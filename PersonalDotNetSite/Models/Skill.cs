using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class Skill
    {
        public int Id { get; set; }

        //name of skill
        public string Name { get; set; }

        //short desc for displaying on cards
        public string ShortDescription { get; set; }

        //long desc for displaying full length
        public string LongDescription { get; set; }

        //pictures associated with this skill
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }

        //skill tags for filtering based on type
        //public string[] SkillTags { get; set; }

        public Skill()
        {
            ImageThumbnailUrl = "/Images/defaultSmall.png";
            ImageUrl = "/Images/defaultBig.jpg";
            Name = "No Title";
            ShortDescription = "No Short Description";
            LongDescription = "No Long Description";
        }
    }
}

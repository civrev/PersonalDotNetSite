using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public Card()
        {
            ImageThumbnailUrl = "/Images/defaultSmall.png";
            ImageUrl = "/Images/defaultBig.jpg";
            Name = "No Title";
            ShortDescription = "No Short Description";
            LongDescription = "No Long Description";
        }
    }
}

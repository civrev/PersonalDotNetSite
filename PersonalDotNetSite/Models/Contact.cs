using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class Contact
    {
        public string Email { get; set; }
        public string AltEmail { get; set; }
        public string GitHubLink { get; set; }
        public string DockerLink { get; set; }
        public string LinkedInLink { get; set; }
        public string PhoneNumber { get; set; }
    }
}

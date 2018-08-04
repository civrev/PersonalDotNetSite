using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    //I only did this to have one file for my fake DBs for development
    public class MockDB
    {
        public class SkillsRepo : ISkillsRepository
        {
            public IEnumerable<Skill> Skills
            {
                get
                {
                    //if using a local path to Images use /Images NOT ~/Images
                    return new List<Skill> { new Skill{Name="Java",
                                                       ShortDescription="Primary Programming Language that I love to use for all sorts of programming fundamentals",
                                                       LongDescription="Powerful OO language that was the center of my acedemic career. I've worked with Java for over 4 years and consider myself capable of reading any java code and working with Java comes naturally to me",
                                                       ImageUrl="/Images/javabig.jpg",
                                                       ImageThumbnailUrl="/Images/javasmall.png" },
                                             new Skill{Name="Java2",
                                                       ShortDescription="Primary Programming Language that I love to use for all sorts of programming fundamentals",
                                                       LongDescription="Powerful OO language that was the center of my acedemic career. I've worked with Java for over 4 years and consider myself capable of reading any java code and working with Java comes naturally to me",
                                                       ImageUrl="/Images/javabig.jpg",
                                                       ImageThumbnailUrl="/Images/javasmall.png" }};
                }
            }

            public Skill getSkillByName(string name)
            {
                throw new NotImplementedException();
            }
        }

        public class ProjectsRepo : IProjectsRepositiory
        {
            public IEnumerable<Project> Projects
            {
                get
                {
                    return new List<Project> { new Project{Name="My Website",
                                                       ShortDescription="A Personal ASP.NET website",
                                                       LongDescription="The website you see before you. Written in ASP.NET Core using MVC and hosted on Azure",
                                                       ImageUrl="~/Images/aspbig.jpg",
                                                       ImageThumbnailUrl="~/Images/aspsmall.jpg" } };
                }
            }

            public Project getProjectByName(string name)
            {
                throw new NotImplementedException();
            }
        }
    }
}

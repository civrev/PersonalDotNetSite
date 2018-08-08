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
            static Skill s1 = new Skill
            {
                Id = 1,
                Name = "Java",
                ShortDescription = "Primary Programming Language that I love to use for all sorts of programming fundamentals",
                LongDescription = "Powerful OO language that was the center of my acedemic career. I've worked with Java for over 4 years and consider myself capable of reading any java code and working with Java comes naturally to me",
                ImageUrl = "/Images/javabig.jpg",
                ImageThumbnailUrl = "/Images/javasmall.png"
            };

            static Skill s2 = new Skill
            {
                Id = 2,
                Name = "Java2",
                ShortDescription = "Primary Programming Language that I love to use for all sorts of programming fundamentals",
                LongDescription = "Powerful OO language that was the center of my acedemic career. I've worked with Java for over 4 years and consider myself capable of reading any java code and working with Java comes naturally to me",
                ImageUrl = "/Images/javabig.jpg",
                ImageThumbnailUrl = "/Images/javasmall.png"
            };

            static List<Skill> skillList = new List<Skill> { s1, s2, s1, s2, s1, s2, s1, s2, s1, s2 };

            public IEnumerable<Skill> Skills
            {
                get
                {
                    return skillList;
                }
            }

            public Skill getSkillByName(string name)
            {
                throw new NotImplementedException();
            }
        }

        public class ProjectsRepo : IProjectsRepositiory
        {
            static Project p1 = new Project
            {
                Id = 1,
                Name = "My Website",
                ShortDescription = "A Personal ASP.NET website, Short Description",
                LongDescription = "The website you see before you. Written in ASP.NET Core using MVC and hosted on Azure",
                ImageUrl = "/Images/aspbig.jpg",
                ImageThumbnailUrl = "/Images/aspsmall.jpg"
            };

            static Project p2 = new Project
            {
                Id = 2,
                Name = "My Website2",
                ShortDescription = "A Personal ASP.NET website, Short Description",
                LongDescription = "The website you see before you. Written in ASP.NET Core using MVC and hosted on Azure",
                ImageUrl = "/Images/aspbig.jpg",
                ImageThumbnailUrl = "/Images/aspsmall.jpg"
            };

            static Project p3 = new Project
            {
                Id = 3,
                Name = "My Website3",
                ShortDescription = "A Personal ASP.NET website, Short Description",
                LongDescription = "The website you see before you. Written in ASP.NET Core using MVC and hosted on Azure",
                ImageUrl = "/Images/aspbig.jpg",
                ImageThumbnailUrl = "/Images/aspsmall.jpg"
            };

            static List<Project> projList = new List<Project> { p1, p2, p3 };

            public IEnumerable<Project> Projects
            {
                get
                {
                    return projList;
                }
            }

            public Project getProjectByName(int id)
            {
                foreach(Project p in projList)
                {
                    if(p.Id == id)
                    {
                        return p;
                    }
                }

                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IProjectsRepositiory
    {
        //get all the projects from the DB
        IEnumerable<Project> Projects { get; }

        Project getProjectByName(string name);
    }
}

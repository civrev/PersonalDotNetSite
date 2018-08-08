using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IProjectsRepositiory
    {
        //get all projects, but leave out fields that are only displayed in the detailed page
        IEnumerable<Project> Projects { get; }

        //show get the entire project with this unique name
        Project getProjectByName(int id);
    }
}

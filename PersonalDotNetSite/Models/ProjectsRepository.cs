using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class ProjectsRepository: IProjectsRepositiory
    {
        private readonly AppDbContext _appDbContext;

        //constructor
        public ProjectsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> Projects => _appDbContext.Projects;

        public Project getProjectByName(int id)
        {
            //return first one it finds by this name which is unique
            return _appDbContext.Projects.FirstOrDefault(p => p.Id == id);
        }

        public Boolean updateProject(Project project)
        {
            //update a project in the database
            int pId = project.Id;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class ProjectsRepository: IProjectsRepositiory
    {
        private readonly AppDbContext _appDbContext;
        Random rand;

        //constructor
        public ProjectsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            rand = new Random();
        }

        public IEnumerable<Project> Items => _appDbContext.Projects;

        public Project getById(int id)
        {
            //return first one it finds by this name which is unique
            return Items.FirstOrDefault(e => e.Id == id);
        }

        public void insert(Project project)
        {
            _appDbContext.Projects.Add(project);
            _appDbContext.SaveChanges();
        }

        public void update(Project project)
        {
            Project dbProj = getById(project.Id);
            dbProj.Name = project.Name;
            dbProj.ShortDescription = project.ShortDescription;
            dbProj.LongDescription = project.LongDescription;
            dbProj.ImageThumbnailUrl = project.ImageThumbnailUrl;
            dbProj.ImageUrl = project.ImageUrl;
            _appDbContext.SaveChanges();
        }

        public Boolean ContainsId(int id)
        {
            return Items.Any(e => e.Id == id);
        }

        public void delete(int id)
        {
            Project element = getById(id);
            _appDbContext.Projects.Remove(element);
            _appDbContext.SaveChanges();
        }

        public Project getRandom()
        {
            int index = rand.Next(0, Items.Count());
            return Items.ElementAt(index);
        }
    }
}

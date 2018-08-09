using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IProjectsRepositiory: IRepository<Project>
    {
        //made for registering during services
        Project getRandom();
    }
}

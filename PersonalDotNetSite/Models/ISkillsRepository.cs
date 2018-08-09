using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface ISkillsRepository: IRepository<Skill>
    {
        //made for registering during services
        Skill getRandom();
    }
}

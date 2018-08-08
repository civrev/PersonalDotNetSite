using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class SkillsRepository: ISkillsRepository
    {
        private readonly AppDbContext _appDbContext;

        //constructor
        public SkillsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Skill> Skills => _appDbContext.Skills;

    }
}

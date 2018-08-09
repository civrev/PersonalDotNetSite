using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class SkillsRepository: ISkillsRepository
    {
        private readonly AppDbContext _appDbContext;
        Random rand;

        //constructor
        public SkillsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            rand = new Random();
        }

        public IEnumerable<Skill> Items => _appDbContext.Skills;

        public Skill getById(int id)
        {
            return Items.FirstOrDefault(e => e.Id == id);
        }

        public void insert(Skill skill)
        {
            _appDbContext.Skills.Add(skill);
            _appDbContext.SaveChanges();
        }

        public void update(Skill skill)
        {
            Skill dbSkill = getById(skill.Id);
            dbSkill.Name = skill.Name;
            dbSkill.ShortDescription = skill.ShortDescription;
            dbSkill.LongDescription = skill.LongDescription;
            dbSkill.ImageThumbnailUrl = skill.ImageThumbnailUrl;
            dbSkill.ImageUrl = skill.ImageUrl;
            _appDbContext.SaveChanges();
        }

        public Boolean ContainsId(int id)
        {
            return Items.Any(e => e.Id == id);
        }

        public void delete(int id)
        {
            Skill element = getById(id);
            _appDbContext.Skills.Remove(element);
            _appDbContext.SaveChanges();
        }

        public Skill getRandom()
        {
            int index = rand.Next(0, Items.Count());
            return Items.ElementAt(index);
        }
    }
}

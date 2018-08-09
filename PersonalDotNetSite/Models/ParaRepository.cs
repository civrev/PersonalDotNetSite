using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class ParaRepository : IParagraphRepository
    {
        private readonly AppDbContext _appDbContext;
        public IEnumerable<Paragraph> Items => _appDbContext.Paragraphs;

        //constructor
        public ParaRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Paragraph> getByType(string type)
        {
            return Items.Where(e => e.Type == type);
        }
            
        public bool ContainsId(int id)
        {
            return Items.Any(e => e.Id == id);
        }

        public void delete(int id)
        {
            Paragraph element = getById(id);
            _appDbContext.Paragraphs.Remove(element);
            _appDbContext.SaveChanges();
        }

        public Paragraph getById(int id)
        {
            return Items.FirstOrDefault(e => e.Id == id);
        }

        public void insert(Paragraph element)
        {
            _appDbContext.Paragraphs.Add(element);
            _appDbContext.SaveChanges();
        }

        public void update(Paragraph para)
        {
            Paragraph dbPara = getById(para.Id);
            dbPara.Text = para.Text;
            _appDbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class FaqRepository : IFaqRepository
    {
        private readonly AppDbContext _appDbContext;
        public IEnumerable<WebsiteFAQ> Items => _appDbContext.Faqs;

        //constructor
        public FaqRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool ContainsId(int id)
        {
            return Items.Any(e => e.Id == id);
        }

        public void delete(int id)
        {
            WebsiteFAQ element = getById(id);
            _appDbContext.Faqs.Remove(element);
            _appDbContext.SaveChanges();
        }

        public WebsiteFAQ getById(int id)
        {
            return Items.FirstOrDefault(e => e.Id == id);
        }

        public void insert(WebsiteFAQ element)
        {
            _appDbContext.Faqs.Add(element);
            _appDbContext.SaveChanges();
        }

        public void update(WebsiteFAQ faq)
        {
            WebsiteFAQ dbFaq = getById(faq.Id);
            dbFaq.Question = faq.Question;
            dbFaq.Answer = faq.Answer;
            _appDbContext.SaveChanges();
        }
    }
}

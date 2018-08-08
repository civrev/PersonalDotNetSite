using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Bio> BioDesc { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Website> WebsiteDesc { get; set; }
        public DbSet<WebsiteFAQ> WebsiteFAQs { get; set; }
        public DbSet<Contact> ContactInfo { get; set; }


    }
}

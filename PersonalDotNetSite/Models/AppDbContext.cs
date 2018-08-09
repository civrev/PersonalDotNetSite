using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PersonalDotNetSite.Models;

namespace PersonalDotNetSite.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<WebsiteFAQ> Faqs { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Paragraph> Paragraphs { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("contact");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AltEmail)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.DockerLink)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.GitHubLink)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedInLink)
                    .IsRequired()
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebsiteFAQ>(entity =>
            {
                entity.ToTable("faqs");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("projects");

                entity.Property(e => e.ImageThumbnailUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LongDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("skills");

                entity.Property(e => e.ImageThumbnailUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LongDescription)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Paragraph>(entity =>
            {
                entity.ToTable("paragraphs");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
        
    }
}

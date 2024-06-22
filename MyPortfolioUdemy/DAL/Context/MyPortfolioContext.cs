using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MyPortfolioUdemy.DAL.Context
{
    public class MyPortfolioContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-QNO3SB5P\\SQLEXPRESS; initial Catalog=MyPortfolioDb; integrated Security=true;");

        }
        public DbSet<Entities.About> Abouts { get; set; }
        public DbSet<Entities.Contact> Contacts { get; set; }
        public DbSet<Entities.Experience> Experiences { get; set; }
        public DbSet<Entities.Feature> Features { get; set; }
        public DbSet<Entities.Message> Messages { get; set; }
        public DbSet<Entities.Portfolio> Portfolios { get; set; }
        public DbSet<Entities.Skill> Skills { get; set; }
        public DbSet<Entities.SocialMedia> SocialMedias { get; set; }
        public DbSet<Entities.Certificate> Certificates { get; set; }
        public DbSet<Entities.Project> Projects { get; set; }
        public DbSet<Entities.Reference> References { get; set; }

    }
}

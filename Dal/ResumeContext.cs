using Dal.Configurations;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ResumeContext : DbContext
    {
        static ResumeContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ResumeContext, Dal.Migrations.Configuration>());
        }

        public ResumeContext()
            : base("Resume")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Resume> Resumes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserProfileConfiguration());
            modelBuilder.Configurations.Add(new ResumeConfiguration());
        }
    }
}


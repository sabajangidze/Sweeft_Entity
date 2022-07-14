using School.Domain;
using System;
using System.Data.Entity;

namespace School.Repository
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base(@"Server =.\SqlExpress; Database = Sweeft_Digital212; integrated security = true")
        {

        }

        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachersPupils> TeachersPupils { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Genetic_Algorithm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENETICS.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost;port=5432;Database=universityDb;user id=postgres;password=1732;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between Course and Teacher
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Teachers)
                .WithMany(t => t.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseTeacher",
                    j => j.HasOne<Teacher>().WithMany().HasForeignKey("TeacherId"),
                    j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"));
            modelBuilder.Entity<Course>().HasKey("Id");
            modelBuilder.Entity<Teacher>().HasKey("Id");
            modelBuilder.Entity<Time>().HasKey("Id");
            modelBuilder.Entity<Group>().HasKey("Id");
        }
    }
}

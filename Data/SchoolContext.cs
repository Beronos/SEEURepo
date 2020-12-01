using SEEU.Models;
using Microsoft.EntityFrameworkCore;


namespace SEEU.Data
{
    public class SchoolContext: DbContext
    {

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {       
                       
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");

            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");

        }
    }
}

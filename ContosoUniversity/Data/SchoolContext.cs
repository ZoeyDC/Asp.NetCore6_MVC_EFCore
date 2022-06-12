using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        //Set<TEntity>()
        //https://docs.microsoft.com/en-us/ef/core/miscellaneous/nullable-reference-types#dbcontext-and-dbset

        public DbSet<Course> Courses => Set<Course>();

        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable(nameof(Course));
            modelBuilder.Entity<Enrollment>().ToTable(nameof(Enrollment));
            modelBuilder.Entity<Student>().ToTable(nameof(Student));
        }
    }
}

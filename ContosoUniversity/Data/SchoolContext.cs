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

        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Instructor> Instructors => Set<Instructor>();
        public DbSet<OfficeAssignment> OfficeAssignments => Set<OfficeAssignment>();
        public DbSet<CourseAssignment> CourseAssignments => Set<CourseAssignment>();

        public DbSet<Person> People => Set<Person>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable(nameof(Course));
            modelBuilder.Entity<Enrollment>().ToTable(nameof(Enrollment));
            //modelBuilder.Entity<Student>().ToTable(nameof(Student));
            modelBuilder.Entity<Department>().ToTable(nameof(Department));
            //modelBuilder.Entity<Instructor>().ToTable(nameof(Instructor));
            modelBuilder.Entity<OfficeAssignment>().ToTable(nameof(OfficeAssignment));
            modelBuilder.Entity<CourseAssignment>().ToTable(nameof(CourseAssignment));
            modelBuilder.Entity<Person>().ToTable(nameof(Person));

            modelBuilder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseID, c.InstructorID });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SymphonyLimited.Entity;

namespace SymphonyLimited.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<EntranceExam> EntranceExams { get; set; }

        public DbSet<StudentResult> StudentResults { get; set; }

    }
}

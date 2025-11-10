using Microsoft.EntityFrameworkCore;
using OneToManyEF.Models.Configuration;
using OneToManyEF.Models.DomainModels;

namespace OneToManyEF.Models.DataLayer
{
    public class ClassScheduleContext : DbContext
    {
        public ClassScheduleContext(DbContextOptions<ClassScheduleContext> options)
            : base(options) 
        { }

        public DbSet<Day> Days { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DayConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new ClassConfig());
        }
    }
}

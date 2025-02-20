using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=AppDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.DepartmentId);


            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Projects)
                .WithMany(e => e.Employees);


            modelBuilder.Entity<Models.Project>()
                .HasOne(e => e.Department)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.DepartmentId);

            modelBuilder.Entity<Models.Project>()
                .OwnsOne(e => e.Interval);

            modelBuilder.Entity<Employee>()
                .OwnsOne(e => e.Address);

            modelBuilder.Entity<Department>()
                .OwnsOne(e => e.Address);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Supervisor)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.SupervisiorId);

            modelBuilder.Entity<Employee>()
                .OwnsOne(e => e.Interval);

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
    }
}

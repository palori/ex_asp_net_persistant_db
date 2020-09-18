using Microsoft.EntityFrameworkCore;

namespace Employees_MySQL.Models
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public EmployeesContext(){} // empty constructor

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string user = "root";
            string password = "root";
            optionsBuilder.UseMySQL($"server=localhost;database=EmployeeDB;user={user};password={password}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // copied from library example
            builder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname);
                entity.Property(e => e.Job);
                entity.Property(e => e.Salary);
            });
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
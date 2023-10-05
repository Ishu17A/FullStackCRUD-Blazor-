using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Web_API_.Model;

namespace Web_API_.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.Employeedata(builder);
        }


        public void Employeedata(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee() { Id = Guid.NewGuid(), Name = "ABC", Brand = "abc", Title = "abca" , Departments = Departments.HR }
                );

            builder.Entity<Employee>().HasData(
            new Employee() { Id = Guid.NewGuid(), Name = "XYZ", Brand = "xyz", Title = "xyza"  , Departments = Departments.SALES }
            );
        }










    }
}

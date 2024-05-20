using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppLeaveManagementSystem.Configurations.Entities;
using WebAppLeaveManagementSystem.Models;

namespace WebAppLeaveManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        //public DbSet<WebAppLeaveManagementSystem.Models.LeaveAllocationEditVM>? LeaveAllocationEditVM { get; set; }
        //public DbSet<WebAppLeaveManagementSystem.Models.EmployeeAllocationVM>? EmployeeAllocationVM { get; set; }
        //public DbSet<WebAppLeaveManagementSystem.Models.EmployeeListVM>? EmployeeListVM { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "65f17b92-811e-484b-9560-9ded9be37db0",
                    Email = "test1@gmail.com",
                    NormalizedEmail= "TEST1@GMAIL.COM",
                    NormalizedUserName = "TEST1@GMAIL.COM",
                    UserName = "test1@gmail.com",
                    Firstname ="Test",
                    Lastname="1",
                    PasswordHash =hasher.HashPassword(null, "Test1@gmail.com"),
                    EmailConfirmed =true
                }
            );
        }
    }
}
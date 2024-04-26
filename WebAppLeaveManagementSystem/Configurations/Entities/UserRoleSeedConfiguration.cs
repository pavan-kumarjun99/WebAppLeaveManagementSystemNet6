using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppLeaveManagementSystem.Data;

namespace WebAppLeaveManagementSystem.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                 new IdentityUserRole<string>
                 {
                     RoleId = "97f18b92-877e-534b-9635-9ded7ce73db1", //ADMIN ROLE
                     UserId = "65f17b92-811e-484b-9560-9ded9be37db0"  //ADMIN ID ... Need to add USER Role also
                 }
            );
        }
    }
}
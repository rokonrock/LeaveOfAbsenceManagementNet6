using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveOfAbsenceManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "408ba955-3e85-3332-5656-7259fg54e838",
                    UserId = "308ca955-3e25-2332-5446-5259fg54e538"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "408ba966-4d85-3331-5655-7259fg54e727",
                    UserId = "407cb955-1e24-1331-1446-1259fg54e118"
                }
            );
        }
    }
}
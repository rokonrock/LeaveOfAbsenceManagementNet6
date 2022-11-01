using LeaveOfAbsenceManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveOfAbsenceManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "408ba955-3e85-3332-5656-7259fg54e838",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "408ba966-4d85-3331-5655-7259fg54e727",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            );
        }
    }
}
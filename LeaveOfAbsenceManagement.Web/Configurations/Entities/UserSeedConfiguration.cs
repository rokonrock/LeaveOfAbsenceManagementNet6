using LeaveOfAbsenceManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveOfAbsenceManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "308ca955-3e25-2332-5446-5259fg54e538",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd7"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "407cb955-1e24-1331-1446-1259fg54e118",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd7"),
                    EmailConfirmed = true
                }
            );

        }
    }
}
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveOfAbsenceManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "408ba955-3e85-3332-5656-7259fg54e838", "9c4c1be6-c740-4a52-ab20-6c4f57fd3bbb", "Administrator", "ADMINISTRATOR" },
                    { "408ba966-4d85-3331-5655-7259fg54e727", "764d118e-c961-45d4-b750-2db8a7460792", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "308ca955-3e25-2332-5446-5259fg54e538", 0, "852f959c-9582-42bc-8bcc-a4e3e720225d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEEThISEq697ol0/YotsoQDxdf79LAwMJ7BBvRbpKGBW2epZLOX06sptt0wsyrkyJrQ==", null, false, "57143aa2-efd8-4883-9c67-440d660eb752", null, false, null },
                    { "407cb955-1e24-1331-1446-1259fg54e118", 0, "123e1172-ffac-4b19-b782-b802b76e89e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHIVG0sY1IJ0s8pzkeq+GhGLYi+b20cBdbwLkg9pg7BS4CulzGw6BxDfTMVgCeURUw==", null, false, "57412782-4d9e-42f2-a544-7425b4b91a62", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "408ba955-3e85-3332-5656-7259fg54e838", "308ca955-3e25-2332-5446-5259fg54e538" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "408ba966-4d85-3331-5655-7259fg54e727", "407cb955-1e24-1331-1446-1259fg54e118" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "408ba955-3e85-3332-5656-7259fg54e838", "308ca955-3e25-2332-5446-5259fg54e538" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "408ba966-4d85-3331-5655-7259fg54e727", "407cb955-1e24-1331-1446-1259fg54e118" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba955-3e85-3332-5656-7259fg54e838");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba966-4d85-3331-5655-7259fg54e727");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308ca955-3e25-2332-5446-5259fg54e538");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "407cb955-1e24-1331-1446-1259fg54e118");
        }
    }
}

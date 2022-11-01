using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveOfAbsenceManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba955-3e85-3332-5656-7259fg54e838",
                column: "ConcurrencyStamp",
                value: "417723b9-a749-472f-89dd-8102784f160f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba966-4d85-3331-5655-7259fg54e727",
                column: "ConcurrencyStamp",
                value: "3f8cdc14-9ecd-49e0-8481-d2aef2dbc42b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308ca955-3e25-2332-5446-5259fg54e538",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd3842b8-cb49-4dbf-a9ad-ccbe9af1be14", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGOx/U7e3auPhNtStiScqk5OC/KqA8B5j7VxO6Ba8o5UEJgpJef4NqIISd/NLXl9IA==", "ed84ef5d-c5bb-4810-8726-f37ba9651441", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "407cb955-1e24-1331-1446-1259fg54e118",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "24896929-5303-4332-ba05-0686d65a945e", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGftC+faWVzsprCODtgjQrfSurZDYb8Gvsy1ySqu6k4dzRXDfkjX5tdt2fMc/E4d7g==", "d6752b4d-fa4a-40c7-b13b-27ea11dfc935", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba955-3e85-3332-5656-7259fg54e838",
                column: "ConcurrencyStamp",
                value: "9c4c1be6-c740-4a52-ab20-6c4f57fd3bbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "408ba966-4d85-3331-5655-7259fg54e727",
                column: "ConcurrencyStamp",
                value: "764d118e-c961-45d4-b750-2db8a7460792");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308ca955-3e25-2332-5446-5259fg54e538",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "852f959c-9582-42bc-8bcc-a4e3e720225d", false, null, "AQAAAAEAACcQAAAAEEThISEq697ol0/YotsoQDxdf79LAwMJ7BBvRbpKGBW2epZLOX06sptt0wsyrkyJrQ==", "57143aa2-efd8-4883-9c67-440d660eb752", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "407cb955-1e24-1331-1446-1259fg54e118",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "123e1172-ffac-4b19-b782-b802b76e89e7", false, null, "AQAAAAEAACcQAAAAEHIVG0sY1IJ0s8pzkeq+GhGLYi+b20cBdbwLkg9pg7BS4CulzGw6BxDfTMVgCeURUw==", "57412782-4d9e-42f2-a544-7425b4b91a62", null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLeaveManagementSystem.Data.Migrations
{
    public partial class AddedDefaultUserADMIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65f17b92-811e-484b-9560-9ded9be37db2", "764fc0d9-a9a1-4a19-b43d-1d3b9dbc24c0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97f18b92-877e-534b-9635-9ded7ce73db1", "7fc23557-daff-4f9b-82dc-92962492d3e8", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoining", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Taxid", "TwoFactorEnabled", "UserName" },
                values: new object[] { "65f17b92-811e-484b-9560-9ded9be37db0", 0, "b5aa1972-c13e-44b1-9255-3ed1b1d2eca5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test1@gmail.com", false, "Test", "1", false, null, "TEST1@GMAIL.COM", null, "AQAAAAEAACcQAAAAEP6jWaFC+85UaTgnT8kHS48thuVamon/F9SEkbgZbiHT/ARwAobYNmc1xZjY6bz7gA==", null, false, "185c2a1c-0333-451b-ac45-4d70b687f98f", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "97f18b92-877e-534b-9635-9ded7ce73db1", "65f17b92-811e-484b-9560-9ded9be37db0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "97f18b92-877e-534b-9635-9ded7ce73db1", "65f17b92-811e-484b-9560-9ded9be37db0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0");
        }
    }
}

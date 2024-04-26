using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLeaveManagementSystem.Data.Migrations
{
    public partial class AddedDefaultUserADMIN1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2",
                column: "ConcurrencyStamp",
                value: "e0a1d1ac-9818-4110-bf16-a5b527c8aa8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1",
                column: "ConcurrencyStamp",
                value: "9a2eed98-0fe5-4b83-878a-6ef6d29ddbc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "806e4b42-e9bc-4c01-85ca-17d8233eabbc", true, "TEST1@GMAIL.COM", "AQAAAAEAACcQAAAAEByejmZYcR61kAwiJl6rqcJjMUAAHhPHzk/+e6cm/RcVSRjHddyNWIpdyo7s/5xmbw==", "2a1b9d2f-f881-4a9d-9196-5634dfe9de65", "test1@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2",
                column: "ConcurrencyStamp",
                value: "764fc0d9-a9a1-4a19-b43d-1d3b9dbc24c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1",
                column: "ConcurrencyStamp",
                value: "7fc23557-daff-4f9b-82dc-92962492d3e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b5aa1972-c13e-44b1-9255-3ed1b1d2eca5", false, null, "AQAAAAEAACcQAAAAEP6jWaFC+85UaTgnT8kHS48thuVamon/F9SEkbgZbiHT/ARwAobYNmc1xZjY6bz7gA==", "185c2a1c-0333-451b-ac45-4d70b687f98f", null });
        }
    }
}

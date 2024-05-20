using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLeaveManagementSystem.Data.Migrations
{
    public partial class addedPeriodcolumninLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2",
                column: "ConcurrencyStamp",
                value: "e2ea895f-4382-4068-a6c6-15b73a482067");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1",
                column: "ConcurrencyStamp",
                value: "10bb70cc-5916-4112-92f2-8b1f1cc57f99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43a2e7a2-8bb8-4b33-a0a2-8d858441ed14", "AQAAAAEAACcQAAAAELCemexWvp4kDCf4pAJzVnPiLBlbeFW7o3Bp1iOOaha6qOFGz8AdqoEob9/kyNBWWg==", "358da84f-5821-4e7e-9eff-cd31b8a4e311" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806e4b42-e9bc-4c01-85ca-17d8233eabbc", "AQAAAAEAACcQAAAAEByejmZYcR61kAwiJl6rqcJjMUAAHhPHzk/+e6cm/RcVSRjHddyNWIpdyo7s/5xmbw==", "2a1b9d2f-f881-4a9d-9196-5634dfe9de65" });
        }
    }
}

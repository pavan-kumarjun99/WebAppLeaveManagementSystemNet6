using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLeaveManagementSystem.Data.Migrations
{
    public partial class Updated_Request_commentsNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2",
                column: "ConcurrencyStamp",
                value: "0ae14f41-68f7-4f35-a297-30544bcc83fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1",
                column: "ConcurrencyStamp",
                value: "36ee3cf9-c20b-41d1-b7f1-07924ce71e50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a69e1725-8019-4d94-b83b-7de8cc6c37cd", "AQAAAAEAACcQAAAAEM6wUyslXpIP+tSo/BPwbzKNlVr/JbnsHvOlGsGKM8IkWiP+mlt58VYN8kN19ltrOw==", "e92ecba2-9f91-4867-a82f-4f00bdd1d32c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db2",
                column: "ConcurrencyStamp",
                value: "43941b49-a79a-4c0a-a0c1-f6449c4dff9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97f18b92-877e-534b-9635-9ded7ce73db1",
                column: "ConcurrencyStamp",
                value: "3bd30d55-8c14-4448-a1cf-db4ee302bb15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65f17b92-811e-484b-9560-9ded9be37db0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e76585d4-0d9d-43e2-b0d1-a949f65241da", "AQAAAAEAACcQAAAAEFJgPATn1ncGmeyHZxPEb8eS9blT3zWP+jgb6HAurlCMmw2cBraMNqCGmwte7Wjurw==", "314b4e45-d248-489b-9796-d3f79cf70e5f" });
        }
    }
}

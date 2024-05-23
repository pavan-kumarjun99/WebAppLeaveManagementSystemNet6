using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppLeaveManagementSystem.Data.Migrations
{
    public partial class AddedLeaveRequestData_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}

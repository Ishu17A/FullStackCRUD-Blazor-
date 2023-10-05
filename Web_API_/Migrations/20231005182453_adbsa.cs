using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API_.Migrations
{
    public partial class adbsa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departments = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Brand", "Departments", "Name", "Title" },
                values: new object[] { new Guid("85bed992-3ed3-41cd-88d2-b8a0974787a2"), "xyz", 3, "XYZ", "xyza" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Brand", "Departments", "Name", "Title" },
                values: new object[] { new Guid("ebefdf9f-216d-40fe-8fac-f4ad40d48adf"), "abc", 0, "ABC", "abca" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Client = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Recrutier = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    EducationLevel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SalaryExpectations = table.Column<float>(type: "real", maxLength: 7, nullable: false),
                    CurrentSalaryGross = table.Column<float>(type: "real", maxLength: 7, nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Q2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Q3 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Q4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Level = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}

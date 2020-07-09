using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCV.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jobbs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobbTitel = table.Column<string>(nullable: true),
                    JobbDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobbs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolTitle = table.Column<string>(nullable: true),
                    SchoolDescription = table.Column<string>(nullable: true),
                    SchoolClasses = table.Column<string>(nullable: true),
                    SchoolDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobbs");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}

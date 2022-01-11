using Microsoft.EntityFrameworkCore.Migrations;

namespace SportNotepadMVC.Infrastructure.Migrations
{
    public partial class FromProfileToProfileUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.CreateTable(
                name: "ProfileUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pb5k = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pb10k = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PbHalfMarathon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PbMarathon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountCompetitions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileUsers");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CountCompetitions = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pb10k = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pb5k = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PbHalfMarathon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PbMarathon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });
        }
    }
}

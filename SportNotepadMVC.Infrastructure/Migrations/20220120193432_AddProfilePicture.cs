using Microsoft.EntityFrameworkCore.Migrations;

namespace SportNotepadMVC.Infrastructure.Migrations
{
    public partial class AddProfilePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Localization",
                table: "Trainings",
                newName: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "Distance",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "ProfileUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Distance",
                table: "Competitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "StartNumber",
                table: "Competitions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "ProfileUsers");

            migrationBuilder.DropColumn(
                name: "StartNumber",
                table: "Competitions");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Trainings",
                newName: "Localization");

            migrationBuilder.AlterColumn<float>(
                name: "Distance",
                table: "Trainings",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Distance",
                table: "Competitions",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

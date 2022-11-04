using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beca.PlaylistInfo.API.Migrations
{
    public partial class CityInfoDBAddSongDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Songs",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Songs");
        }
    }
}

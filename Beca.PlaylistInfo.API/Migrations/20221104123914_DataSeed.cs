using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beca.PlaylistInfo.API.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "La bachata que más nos gusta.", "Bachata Remix" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "El reggaeton que más nos gusta.", "Reggaeton Remix" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Tus canciones de pop más escuchadas.", "Coldplay Remix" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 1, "Canción buenísima de nuestro amigo Manuel Turizo que está llenando conciertos.", "La Bachata - Manuel Turizo", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 2, "Clasicazo de canción, nunca puede faltar cuando hablamos de bachata.", "Propuesta Indecente - Romeo Santos", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 3, "Si necesitas descripción para semejante temazo seguramente seas menor de edad.", "La Gasolina", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 4, "Canción de Feid de su álbum Cumpleaños Feliz.", "Normal - Ferxxo", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 5, "Himno de Coldplay, no necesita más descripición.", "The Scientist", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Description", "Name", "PlayListId" },
                values: new object[] { 6, "Otra de sus más famosas canciones, bárbaro.", "Adventure Of A Lifetime", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Playlists",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string [] { "Nome", "AnoLancamento" }, new object [] { "Oceano", 1989 });

            migrationBuilder.InsertData("Musicas", new string[] {"Nome", "AnoLancamento"}, new object[] {"Bad Romance", 2008});

            migrationBuilder.InsertData("Musicas", new string [] { "Nome", "AnoLancamento" }, new object [] { "Vai Malandra", 2017 });

            migrationBuilder.InsertData("Musicas", new string [] { "Nome", "AnoLancamento" }, new object [] { "Dont Start Now", 2019 });

            migrationBuilder.InsertData("Musicas", new string [] { "Nome", "AnoLancamento" }, new object [] { "Like a Virgin", 1984 });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}

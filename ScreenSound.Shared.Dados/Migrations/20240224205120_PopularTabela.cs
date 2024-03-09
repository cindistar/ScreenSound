using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string [] { "Nome", "Bio", "FotoPerfil" }, new object [] { "Djavan", "É um cantor brasileiro e suas músicas são muito boas.", "https://cdn.folhape.com.br/img/c/1200/900/dn_arquivo/2019/05/djavan-chamada.jpg"});

            migrationBuilder.InsertData("Artistas", new string [] { "Nome", "Bio", "FotoPerfil" }, new object [] { "Lady Gaga", "Lady Gaga, nascida Stefani Joanne Angelina Germanotta, é uma cantora, compositora e atriz conhecida por sua música inovadora e estilo extravagante.", "https://metropolitanafm.com.br/wp-content/uploads/2022/10/Lady-Gaga-Biografia-Ultimas-Noticias-Curiosidades-Idade-e-muito-mais.jpg" });

            migrationBuilder.InsertData("Artistas", new string [] { "Nome", "Bio", "FotoPerfil" }, new object [] { "Anitta", "Anitta é uma cantora, compositora e empresária brasileira conhecida por sua versatilidade musical e sucesso internacional.", "https://f.i.uol.com.br/fotografia/2022/03/25/1648233649623e0cb15be5e_1648233649_3x4_md.jpg" });

            migrationBuilder.InsertData("Artistas", new string [] { "Nome", "Bio", "FotoPerfil" }, new object [] { "Dua Lipa", "Dua Lipa é uma cantora e compositora britânica de ascendência albanesa, conhecida por seu estilo único e sucessos como New Rules e Don't Start Now.", "https://media.glamour.mx/photos/62ed1ccb19bc2a09ec1c2bc8/1:1/pass/dua-lipa-fluffy-brows-gettyimages-1404303105.jpg" });

            migrationBuilder.InsertData("Artistas", new string [] { "Nome", "Bio", "FotoPerfil" }, new object [] { "Madonna", "Madonna é uma ícone da música pop, conhecida por sua reinvenção constante e por empoderar gerações com sua música e estilo provocativo.", "https://www.otempo.com.br/image/contentid/policy:1.3316207:1705941824/madonna-vem-ao-brasil-em-2024-jpg.jpg?f=3x2&w=1224" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGames.Migrations
{
    /// <inheritdoc />
    public partial class AddGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Games(Name,ShortDescription,DetailedDescription,Price,ImageUrl,ImageThumbnailUrl,Available,GenderId)"
                + "VALUES('Bloodborne','Bloodborne é um RPG de ação gótico, onde o jogador enfrenta monstros e desvenda mistérios em uma cidade sombria.','Ambientado na sombria e gótica cidade de Yharnam, o jogador assume o papel de um Caçador, enfrentando hordas de criaturas monstruosas e desvendando mistérios envolvendo uma doença sobrenatural.',100.00,'C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\BB\\BB3.jpg','C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\BB\\BBThumb.jpg',1,1)");

            migrationBuilder.Sql("INSERT INTO Games(Name,ShortDescription,DetailedDescription,Price,ImageUrl,ImageThumbnailUrl,Available,GenderId)"
                + "VALUES('Call of Duty: Black Ops 6','O novo capítulo nos leva a uma versão alternativa de 1991 e está disposto a mostrar que aquilo que conhecemos nem sempre é a realidade verdadeira.','Desenvolvido por Treyarch e Raven, Black Ops 6 é um jogo de ação com suspense e espionagem que se passa no início dos anos 1990, um período de transição e tumulto na política global.',340.00,'C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\COD\\COD2.png','C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\COD\\CODThumb.jpeg',1,2)");

            migrationBuilder.Sql("INSERT INTO Games(Name,ShortDescription,DetailedDescription,Price,ImageUrl,ImageThumbnailUrl,Available,GenderId)"
                + "VALUES('EA Sports FC 25','Experimente mais maneiras de vencer pelo clube no EA SPORTS FC™ 25.','Jogue seus modos favoritos com suas amizades no novo Rush 5 contra 5 e gerencie seu clube rumo à vitória com o controle tático aprimorado do FC IQ.',350.00,'C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\EAFC\\EAFC4.jpg','C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\EAFC\\EAFCThumb.jpeg',1,3)");

            migrationBuilder.Sql("INSERT INTO Games(Name,ShortDescription,DetailedDescription,Price,ImageUrl,ImageThumbnailUrl,Available,GenderId)"
                + "VALUES('God Of War Ragnarok','É um jogo de ação e aventura que segue Kratos e Atreus enfrentando deuses nórdicos enquanto tentam evitar o fim do mundo.','Com combates intensos, narrativa envolvente e cenários deslumbrantes, é a épica conclusão da saga nórdica.',350.00,'C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\GOW\\GOW2.jpg','C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\GOW\\GOWThumb.jpg',1,4)");

            migrationBuilder.Sql("INSERT INTO Games(Name,ShortDescription,DetailedDescription,Price,ImageUrl,ImageThumbnailUrl,Available,GenderId)"
                + "VALUES('The Last Of Us Part II Remastered','Um jogo de ação e sobrevivência que acompanha Ellie em uma jornada de vingança em um mundo pós-apocalíptico.','Com narrativa emocional, gráficos impressionantes e gameplay intenso, é uma experiência profundamente impactante.',250.00,'C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\TLOUP2\\TLOU2.jpg','C:\\Users\\Laeverton\\Documents\\C#\\MyGames\\MyGames\\wwwroot\\images\\TLOUP2\\TLOUThumbnail.jpg',1,5)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Games");
        }
    }
}

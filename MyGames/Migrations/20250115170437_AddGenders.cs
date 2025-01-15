using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGames.Migrations
{
    /// <inheritdoc />
    public partial class AddGenders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genders(GenderName,Description)" + "VALUES('RPG', 'Possui altos níveis de dificuldade e ênfase na narrativa ambiental')");
            migrationBuilder.Sql("INSERT INTO Genders(GenderName,Description)" + "VALUES('Ação', 'Desafios físicos, como batalhas, que exigem rapidez de reação e coordenação')");
            migrationBuilder.Sql("INSERT INTO Genders(GenderName,Description)" + "VALUES('Esportes', 'Simulação de esportes com fidelidade')");
            migrationBuilder.Sql("INSERT INTO Genders(GenderName,Description)" + "VALUES('Aventura', 'se caracterizam por focar na história, na exploração e na resolução de problemas')");
            migrationBuilder.Sql("INSERT INTO Genders(GenderName,Description)" + "VALUES('Terror de Sobrevivência', 'se caracterizam em sobreviver a situações extremas, como escapar de assassinos, em um ambiente de tensão e perigo')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genders");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADE_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADE",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "PassworsHash" },
                values: new object[] { new byte[] { 35, 166, 143, 42, 191, 208, 147, 191, 195, 165, 91, 228, 196, 14, 180, 68, 71, 199, 18, 89, 165, 15, 222, 238, 126, 49, 155, 118, 61, 220, 12, 52, 105, 217, 55, 27, 250, 242, 227, 31, 231, 142, 71, 98, 159, 145, 229, 62, 154, 13, 127, 112, 25, 23, 66, 149, 184, 43, 2, 102, 80, 184, 242, 123, 142, 38, 210, 111, 39, 127, 78, 128, 113, 17, 212, 101, 98, 136, 25, 66, 67, 249, 187, 85, 207, 107, 91, 75, 106, 37, 59, 55, 118, 220, 38, 244, 2, 246, 176, 169, 148, 24, 144, 220, 238, 123, 145, 25, 183, 120, 82, 91, 60, 131, 110, 107, 252, 67, 17, 165, 174, 201, 84, 232, 247, 237, 97, 4 }, new byte[] { 250, 223, 210, 91, 149, 217, 241, 86, 20, 99, 158, 43, 242, 186, 235, 124, 7, 36, 95, 191, 217, 47, 43, 213, 191, 137, 36, 38, 182, 76, 69, 81, 118, 73, 134, 177, 39, 95, 143, 233, 232, 126, 62, 173, 146, 95, 81, 214, 185, 146, 90, 31, 77, 56, 55, 199, 237, 87, 40, 106, 2, 180, 206, 46 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADE");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "PassworsHash" },
                values: new object[] { new byte[] { 162, 134, 20, 145, 0, 165, 42, 59, 7, 133, 10, 122, 20, 37, 35, 210, 81, 253, 198, 114, 197, 87, 127, 59, 205, 117, 254, 114, 91, 198, 174, 135, 211, 152, 0, 204, 32, 7, 67, 40, 31, 131, 189, 209, 74, 213, 218, 116, 71, 226, 14, 253, 190, 116, 96, 221, 196, 177, 124, 1, 210, 13, 198, 142, 208, 168, 20, 124, 134, 92, 125, 143, 252, 59, 84, 214, 54, 212, 137, 147, 246, 119, 62, 8, 176, 168, 206, 237, 228, 144, 180, 97, 21, 105, 195, 67, 61, 254, 213, 88, 122, 71, 94, 167, 207, 0, 121, 211, 143, 240, 122, 197, 49, 132, 44, 104, 250, 20, 175, 146, 84, 11, 76, 144, 67, 42, 120, 226 }, new byte[] { 202, 104, 122, 105, 38, 75, 71, 205, 27, 234, 145, 1, 255, 20, 44, 69, 130, 6, 46, 232, 175, 59, 24, 80, 203, 49, 107, 47, 139, 135, 57, 85, 246, 166, 143, 27, 75, 126, 210, 65, 180, 109, 224, 197, 123, 232, 189, 51, 167, 117, 190, 66, 213, 206, 67, 152, 78, 55, 219, 20, 150, 70, 44, 99 } });
        }
    }
}

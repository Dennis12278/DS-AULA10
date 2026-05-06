using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "PassworsHash" },
                values: new object[] { new byte[] { 162, 134, 20, 145, 0, 165, 42, 59, 7, 133, 10, 122, 20, 37, 35, 210, 81, 253, 198, 114, 197, 87, 127, 59, 205, 117, 254, 114, 91, 198, 174, 135, 211, 152, 0, 204, 32, 7, 67, 40, 31, 131, 189, 209, 74, 213, 218, 116, 71, 226, 14, 253, 190, 116, 96, 221, 196, 177, 124, 1, 210, 13, 198, 142, 208, 168, 20, 124, 134, 92, 125, 143, 252, 59, 84, 214, 54, 212, 137, 147, 246, 119, 62, 8, 176, 168, 206, 237, 228, 144, 180, 97, 21, 105, 195, 67, 61, 254, 213, 88, 122, 71, 94, 167, 207, 0, 121, 211, 143, 240, 122, 197, 49, 132, 44, 104, 250, 20, 175, 146, 84, 11, 76, 144, 67, 42, 120, 226 }, new byte[] { 202, 104, 122, 105, 38, 75, 71, 205, 27, 234, 145, 1, 255, 20, 44, 69, 130, 6, 46, 232, 175, 59, 24, 80, 203, 49, 107, 47, 139, 135, 57, 85, 246, 166, 143, 27, 75, 126, 210, 65, 180, 109, 224, 197, 123, 232, 189, 51, 167, 117, 190, 66, 213, 206, 67, 152, 78, 55, 219, 20, 150, 70, 44, 99 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordSalt", "PassworsHash" },
                values: new object[] { new byte[] { 133, 137, 165, 153, 69, 77, 3, 42, 94, 116, 12, 1, 158, 193, 221, 66, 152, 40, 57, 93, 232, 55, 252, 62, 80, 155, 251, 185, 201, 7, 246, 6, 223, 6, 34, 18, 1, 226, 136, 57, 237, 157, 81, 244, 213, 145, 139, 71, 123, 47, 142, 0, 172, 177, 109, 114, 44, 59, 26, 90, 220, 189, 168, 173, 238, 66, 125, 143, 69, 158, 168, 20, 208, 212, 23, 113, 94, 86, 163, 17, 217, 174, 89, 24, 224, 20, 68, 117, 66, 174, 156, 161, 138, 152, 164, 29, 83, 14, 122, 105, 190, 12, 75, 65, 171, 124, 51, 70, 103, 232, 245, 51, 181, 201, 73, 73, 106, 147, 143, 79, 140, 46, 176, 216, 219, 91, 84, 160 }, new byte[] { 123, 227, 122, 218, 68, 7, 166, 97, 142, 118, 111, 133, 230, 107, 189, 84, 137, 132, 100, 104, 77, 46, 131, 95, 69, 122, 0, 111, 179, 45, 147, 31, 67, 212, 59, 142, 71, 186, 43, 190, 145, 2, 170, 87, 90, 194, 203, 72, 35, 163, 105, 202, 235, 232, 84, 141, 47, 84, 68, 48, 58, 2, 184, 153 } });
        }
    }
}

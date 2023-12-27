using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFAcademy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_T_CategoriaPrato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaPrato",
                columns: table => new
                {
                    CategoriaPratoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPrato", x => x.CategoriaPratoId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Prato_CategoriaPrato_PratoId",
                table: "Prato",
                column: "PratoId",
                principalTable: "CategoriaPrato",
                principalColumn: "CategoriaPratoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prato_CategoriaPrato_PratoId",
                table: "Prato");

            migrationBuilder.DropTable(
                name: "CategoriaPrato");
        }
    }
}

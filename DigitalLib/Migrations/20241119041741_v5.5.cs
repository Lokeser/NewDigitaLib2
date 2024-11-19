using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalLib.Migrations
{
    /// <inheritdoc />
    public partial class v55 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LivrosSelecionados",
                table: "Aluguel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LivrosSelecionados",
                table: "Aluguel",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

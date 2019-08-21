using Microsoft.EntityFrameworkCore.Migrations;

namespace Otamix1.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataMensagenId",
                table: "Comentario",
                newName: "DataMensagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataMensagem",
                table: "Comentario",
                newName: "DataMensagenId");
        }
    }
}

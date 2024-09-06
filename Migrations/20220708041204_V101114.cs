using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabajo_6.Migrations
{
    public partial class V101114 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "vacunador",
                table: "Personas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "vacunador",
                table: "Personas");
        }
    }
}

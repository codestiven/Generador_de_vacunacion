using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trabajo_6.Migrations
{
    public partial class V10111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Centro",
                table: "Personas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "Personas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Centro",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Personas");
        }
    }
}

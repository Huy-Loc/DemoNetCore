using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Migrations
{
    public partial class create_table_demo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressPer",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressPer",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}

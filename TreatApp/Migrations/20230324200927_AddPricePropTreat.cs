using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreatApp.Migrations
{
    public partial class AddPricePropTreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Treats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Treats");
        }
    }
}

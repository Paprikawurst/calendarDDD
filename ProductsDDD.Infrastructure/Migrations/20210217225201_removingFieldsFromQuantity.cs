using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsDDD.Infrastructure.Migrations
{
    public partial class removingFieldsFromQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductEntity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductEntity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

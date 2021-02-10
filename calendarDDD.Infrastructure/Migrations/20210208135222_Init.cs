using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace calendarDDD.Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductEntity",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { new Guid("cbb4e938-3be3-41cf-a52b-efbf30b45b01"), "This is a best gaming laptop", "Laptop", 20.02, 10 });

            migrationBuilder.InsertData(
                table: "ProductEntity",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { new Guid("4f050d87-4b07-4862-aee3-a01c1c788897"), "This is a Office Application", "Microsoft Office", 20.989999999999998, 50 });

            migrationBuilder.InsertData(
                table: "ProductEntity",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { new Guid("464d6ee0-a4c1-4175-92a4-aa4e7cdf77b6"), "The mouse that works on all surface", "Lazer Mouse", 12.02, 20 });

            migrationBuilder.InsertData(
                table: "ProductEntity",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity" },
                values: new object[] { new Guid("dfb152ee-8107-4bc6-8ff7-1a6746dc8f3d"), "To store 256GB of data", "USB Storage", 5.0, 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductEntity");
        }
    }
}

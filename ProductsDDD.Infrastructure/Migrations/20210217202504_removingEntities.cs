using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductsDDD.Infrastructure.Migrations
{
    public partial class removingEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "TeamEntity");

            migrationBuilder.AddColumn<int>(
                name: "ProductType",
                table: "ProductEntity",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "ProductEntity");

            migrationBuilder.CreateTable(
                name: "TeamEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PreName = table.Column<string>(type: "TEXT", nullable: true),
                    SurName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEntity_TeamEntity_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TeamEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_TeamId",
                table: "UserEntity",
                column: "TeamId");
        }
    }
}

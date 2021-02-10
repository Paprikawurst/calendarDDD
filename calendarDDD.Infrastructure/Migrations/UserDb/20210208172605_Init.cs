using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace calendarDDD.Infrastructure.Migrations.UserDb
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "UserEntity",
                columns: new[] { "Id", "PreName", "SurName", "TeamId" },
                values: new object[] { new Guid("fc781a75-9cf3-49b9-b273-80c577bd2ba3"), "Hans", "Müller", null });

            migrationBuilder.InsertData(
                table: "UserEntity",
                columns: new[] { "Id", "PreName", "SurName", "TeamId" },
                values: new object[] { new Guid("20ff1e9b-cf1d-4dd1-ac43-f0a0568b336f"), "Maria", "Schmidt", null });

            migrationBuilder.InsertData(
                table: "UserEntity",
                columns: new[] { "Id", "PreName", "SurName", "TeamId" },
                values: new object[] { new Guid("63b8cd3d-0000-4f22-8eb0-c46833c647e4"), "Peter", "Fischer", null });

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_TeamId",
                table: "UserEntity",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "TeamEntity");
        }
    }
}

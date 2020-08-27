using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TVMaze.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RTLshows",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTLshows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    RTLshowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Casts_RTLshows_RTLshowId",
                        column: x => x.RTLshowId,
                        principalTable: "RTLshows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Casts_RTLshowId",
                table: "Casts",
                column: "RTLshowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "RTLshows");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFenris.Data.Migrations
{
    public partial class add_budget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    Allowance = table.Column<int>(nullable: false),
                    Expenditure = table.Column<int>(nullable: false),
                    Income = table.Column<int>(nullable: false),
                    Users = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}

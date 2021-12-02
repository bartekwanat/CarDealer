using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealer.Migrations
{
    public partial class ProductionDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ProductionYear",
                table: "Car",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductionYear",
                table: "Car");
        }
    }
}

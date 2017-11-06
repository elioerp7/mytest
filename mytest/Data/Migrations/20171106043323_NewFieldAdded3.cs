using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mytest.Data.Migrations
{
    public partial class NewFieldAdded3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShiptoAdd",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiptoCity",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShiptoState",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShiptoZip",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShiptoAdd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShiptoCity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShiptoState",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShiptoZip",
                table: "AspNetUsers");
        }
    }
}

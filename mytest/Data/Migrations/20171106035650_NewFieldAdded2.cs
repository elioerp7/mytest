using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mytest.Data.Migrations
{
    public partial class NewFieldAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BilltoAdd",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BilltoCity",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BilltoState",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BilltoZip",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BilltoAdd",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BilltoCity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BilltoState",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BilltoZip",
                table: "AspNetUsers");
        }
    }
}

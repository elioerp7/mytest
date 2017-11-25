using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace mytest.Data.Migrations
{
    public partial class bigfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "ShoppingCartItems");

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

            migrationBuilder.AddColumn<string>(
                name: "BilltoZip",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CCnum",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "ShiptoZip",
                table: "AspNetUsers",
                nullable: true);
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

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CCnum",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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

            //migrationBuilder.CreateTable(
            //    name: "ShoppingCartItems",
            //    columns: table => new
            //    {
            //        ShoppingCartItemId = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Amount = table.Column<int>(nullable: false),
            //        BookISBN = table.Column<string>(nullable: true),
            //        ShoppingCartId = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
            //        table.ForeignKey(
            //            name: "FK_ShoppingCartItems_Books_BookISBN",
            //            column: x => x.BookISBN,
            //            principalTable: "Books",
            //            principalColumn: "ISBN",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ShoppingCartItems_BookISBN",
            //    table: "ShoppingCartItems",
            //    column: "BookISBN");
        }
    }
}

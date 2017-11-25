using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mytest.Data.Migrations
{
    public partial class fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BilltoAdd1",
                table: "AspNetUsers",
                newName: "BilltoAdd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bamboo.Migrations
{
    public partial class AddedEmailToUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "users",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "users",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "users");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "users",
                nullable: true);
        }
    }
}

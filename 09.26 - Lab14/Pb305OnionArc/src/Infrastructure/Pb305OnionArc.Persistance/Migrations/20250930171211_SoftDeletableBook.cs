using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pb305OnionArc.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeletableBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Authors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Authors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Authors");
        }
    }
}

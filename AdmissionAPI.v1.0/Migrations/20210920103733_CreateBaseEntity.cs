using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionAPI.v1._0.Migrations
{
    public partial class CreateBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "University",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "University",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "University",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "University",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "UniStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UniStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "UniStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "UniStatus",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "University");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "University");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "University");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "University");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "UniStatus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UniStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UniStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "UniStatus");
        }
    }
}

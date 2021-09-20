using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionAPI.v1._0.Migrations
{
    public partial class UndoCreateBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Base_Base_StatusId",
                table: "Base");

            migrationBuilder.DropForeignKey(
                name: "FK_UniAddress_Base_UniversityId",
                table: "UniAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Base",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Base");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Base");

            migrationBuilder.RenameTable(
                name: "Base",
                newName: "University");

            migrationBuilder.RenameIndex(
                name: "IX_Base_StatusId",
                table: "University",
                newName: "IX_University_StatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_University",
                table: "University",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UniStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniStatus", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UniAddress_University_UniversityId",
                table: "UniAddress",
                column: "UniversityId",
                principalTable: "University",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_University_UniStatus_StatusId",
                table: "University",
                column: "StatusId",
                principalTable: "UniStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniAddress_University_UniversityId",
                table: "UniAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_University_UniStatus_StatusId",
                table: "University");

            migrationBuilder.DropTable(
                name: "UniStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_University",
                table: "University");

            migrationBuilder.RenameTable(
                name: "University",
                newName: "Base");

            migrationBuilder.RenameIndex(
                name: "IX_University_StatusId",
                table: "Base",
                newName: "IX_Base_StatusId");

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "Base",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Base",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Base",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Base",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "Base",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Base",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Base",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Base",
                table: "Base",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Base_Base_StatusId",
                table: "Base",
                column: "StatusId",
                principalTable: "Base",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UniAddress_Base_UniversityId",
                table: "UniAddress",
                column: "UniversityId",
                principalTable: "Base",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

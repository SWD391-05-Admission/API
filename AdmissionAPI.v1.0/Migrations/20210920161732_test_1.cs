using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdmissionAPI.v1._0.Migrations
{
    public partial class test_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "MajorStatus");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MajorStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "MajorStatus");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "MajorStatus");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "UniAddress",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CounStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MajorStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Major_MajorStatus_MajorStatusId",
                        column: x => x.MajorStatusId,
                        principalTable: "MajorStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniversityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalkshowStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalkshowStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counselor",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CounStatusId = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counselor", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Counselor_CounStatus_CounStatusId",
                        column: x => x.CounStatusId,
                        principalTable: "CounStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UniMajor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityId = table.Column<int>(type: "int", nullable: true),
                    MajorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniMajor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UniMajor_Major_MajorId",
                        column: x => x.MajorId,
                        principalTable: "Major",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UniMajor_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudentStatusId = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Student_StudentStatus_StudentStatusId",
                        column: x => x.StudentStatusId,
                        principalTable: "StudentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CounPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounselorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounPhone_Counselor_CounselorUserId",
                        column: x => x.CounselorUserId,
                        principalTable: "Counselor",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Talkshow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalkshowStatusId = table.Column<int>(type: "int", nullable: true),
                    CounselorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talkshow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talkshow_Counselor_CounselorUserId",
                        column: x => x.CounselorUserId,
                        principalTable: "Counselor",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Talkshow_TalkshowStatus_TalkshowStatusId",
                        column: x => x.TalkshowStatusId,
                        principalTable: "TalkshowStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CounUniMajor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CounselorUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UniMajorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounUniMajor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounUniMajor_Counselor_CounselorUserId",
                        column: x => x.CounselorUserId,
                        principalTable: "Counselor",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CounUniMajor_UniMajor_UniMajorId",
                        column: x => x.UniMajorId,
                        principalTable: "UniMajor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentPhone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPhone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentPhone_Student_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Student",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_Student_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Student",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalkshowId = table.Column<int>(type: "int", nullable: true),
                    StudentUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slot_Student_StudentUserId",
                        column: x => x.StudentUserId,
                        principalTable: "Student",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Slot_Talkshow_TalkshowId",
                        column: x => x.TalkshowId,
                        principalTable: "Talkshow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TalkshowUniMajor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TalkshowId = table.Column<int>(type: "int", nullable: true),
                    UniMajorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalkshowUniMajor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalkshowUniMajor_Talkshow_TalkshowId",
                        column: x => x.TalkshowId,
                        principalTable: "Talkshow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TalkshowUniMajor_UniMajor_UniMajorId",
                        column: x => x.UniMajorId,
                        principalTable: "UniMajor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniAddress_DistrictId",
                table: "UniAddress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CounPhone_CounselorUserId",
                table: "CounPhone",
                column: "CounselorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Counselor_CounStatusId",
                table: "Counselor",
                column: "CounStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CounUniMajor_CounselorUserId",
                table: "CounUniMajor",
                column: "CounselorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CounUniMajor_UniMajorId",
                table: "CounUniMajor",
                column: "UniMajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Major_MajorStatusId",
                table: "Major",
                column: "MajorStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_UniversityId",
                table: "Question",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_StudentUserId",
                table: "Slot",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Slot_TalkshowId",
                table: "Slot",
                column: "TalkshowId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentStatusId",
                table: "Student",
                column: "StudentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPhone_StudentUserId",
                table: "StudentPhone",
                column: "StudentUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Talkshow_CounselorUserId",
                table: "Talkshow",
                column: "CounselorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Talkshow_TalkshowStatusId",
                table: "Talkshow",
                column: "TalkshowStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TalkshowUniMajor_TalkshowId",
                table: "TalkshowUniMajor",
                column: "TalkshowId");

            migrationBuilder.CreateIndex(
                name: "IX_TalkshowUniMajor_UniMajorId",
                table: "TalkshowUniMajor",
                column: "UniMajorId");

            migrationBuilder.CreateIndex(
                name: "IX_UniMajor_MajorId",
                table: "UniMajor",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_UniMajor_UniversityId",
                table: "UniMajor",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_StudentUserId",
                table: "Wallet",
                column: "StudentUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UniAddress_District_DistrictId",
                table: "UniAddress",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniAddress_District_DistrictId",
                table: "UniAddress");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "CounPhone");

            migrationBuilder.DropTable(
                name: "CounUniMajor");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Slot");

            migrationBuilder.DropTable(
                name: "StudentPhone");

            migrationBuilder.DropTable(
                name: "TalkshowUniMajor");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Talkshow");

            migrationBuilder.DropTable(
                name: "UniMajor");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Counselor");

            migrationBuilder.DropTable(
                name: "TalkshowStatus");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "StudentStatus");

            migrationBuilder.DropTable(
                name: "CounStatus");

            migrationBuilder.DropIndex(
                name: "IX_UniAddress_DistrictId",
                table: "UniAddress");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "UniAddress");

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

            migrationBuilder.AddColumn<int>(
                name: "CreateBy",
                table: "MajorStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MajorStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "MajorStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "MajorStatus",
                type: "datetime2",
                nullable: true);
        }
    }
}

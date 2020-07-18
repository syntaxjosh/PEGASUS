using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pegasus.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barangay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarangayName = table.Column<string>(nullable: true),
                    BarangayAddress = table.Column<string>(nullable: true),
                    BarangayLocation = table.Column<string>(nullable: true),
                    BarangayLogoPath = table.Column<string>(nullable: true),
                    BarangayQrCode = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barangay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LguProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LguName = table.Column<string>(nullable: true),
                    LguAddress = table.Column<string>(nullable: true),
                    LguLocation = table.Column<string>(nullable: true),
                    LguLogoPath = table.Column<string>(nullable: true),
                    LguQrCode = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LguProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fullname = table.Column<string>(nullable: true),
                    LguId = table.Column<int>(nullable: true),
                    BgryId = table.Column<int>(nullable: true),
                    QrCode = table.Column<string>(nullable: true),
                    PicPath = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    BarangayId = table.Column<int>(nullable: true),
                    PrincipalPersonId = table.Column<int>(nullable: true),
                    QDays = table.Column<int>(nullable: true),
                    QDateStarted = table.Column<DateTime>(nullable: true),
                    QDateEnded = table.Column<DateTime>(nullable: true),
                    PersonStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonProfile_Barangay_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonProfile_LguProfile_LguId",
                        column: x => x.LguId,
                        principalTable: "LguProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonProfile_BarangayId",
                table: "PersonProfile",
                column: "BarangayId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonProfile_LguId",
                table: "PersonProfile",
                column: "LguId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonProfile");

            migrationBuilder.DropTable(
                name: "Barangay");

            migrationBuilder.DropTable(
                name: "LguProfile");
        }
    }
}

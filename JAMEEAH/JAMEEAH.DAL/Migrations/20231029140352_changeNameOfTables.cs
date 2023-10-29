using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JAMEEAH.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeNameOfTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Jameeahs_JameeahsId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Jameeahs");

            migrationBuilder.RenameColumn(
                name: "JameeahsId",
                table: "Members",
                newName: "_JameeahId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_JameeahsId",
                table: "Members",
                newName: "IX_Members__JameeahId");

            migrationBuilder.CreateTable(
                name: "Jameeah",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfMember = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstallmentsCount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jameeah", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Jameeah__JameeahId",
                table: "Members",
                column: "_JameeahId",
                principalTable: "Jameeah",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Jameeah__JameeahId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Jameeah");

            migrationBuilder.RenameColumn(
                name: "_JameeahId",
                table: "Members",
                newName: "JameeahsId");

            migrationBuilder.RenameIndex(
                name: "IX_Members__JameeahId",
                table: "Members",
                newName: "IX_Members_JameeahsId");

            migrationBuilder.CreateTable(
                name: "Jameeahs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InstallmentsCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfMember = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jameeahs", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Jameeahs_JameeahsId",
                table: "Members",
                column: "JameeahsId",
                principalTable: "Jameeahs",
                principalColumn: "Id");
        }
    }
}

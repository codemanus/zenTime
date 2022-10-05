using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace zenTime.Server.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeTracking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HoursAmount = table.Column<double>(type: "float", nullable: false),
                    TimeTrackingModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HourModels_TimeTracking_TimeTrackingModelId",
                        column: x => x.TimeTrackingModelId,
                        principalTable: "TimeTracking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HourModels_TimeTrackingModelId",
                table: "HourModels",
                column: "TimeTrackingModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourModels");

            migrationBuilder.DropTable(
                name: "TimeTracking");
        }
    }
}

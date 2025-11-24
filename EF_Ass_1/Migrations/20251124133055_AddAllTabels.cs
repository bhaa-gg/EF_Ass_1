using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Ass_1.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Airline_AirlineId",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airline",
                table: "Airline");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Airline",
                newName: "AirLines");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_AirlineId",
                table: "Employees",
                newName: "IX_Employees_AirlineId");

            migrationBuilder.AddColumn<string>(
                name: "Phones",
                table: "AirLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AirLines",
                table: "AirLines",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AirCrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    AirlineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirCrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirCrafts_AirLines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AirlineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_AirLines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maj_Pilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assis_Pilot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Host2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirCraftId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crews_AirCrafts_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignedRoutes",
                columns: table => new
                {
                    AirCraftId = table.Column<int>(type: "int", nullable: false),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    Departure = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Arrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    NumOfPassengers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedRoutes", x => new { x.AirCraftId, x.RouteId });
                    table.ForeignKey(
                        name: "FK_AssignedRoutes_AirCrafts_AirCraftId",
                        column: x => x.AirCraftId,
                        principalTable: "AirCrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignedRoutes_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_AirlineId",
                table: "AirCrafts",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedRoutes_RouteId",
                table: "AssignedRoutes",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_AirCraftId",
                table: "Crews",
                column: "AirCraftId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AirlineId",
                table: "Transactions",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AirLines_AirlineId",
                table: "Employees",
                column: "AirlineId",
                principalTable: "AirLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AirLines_AirlineId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "AssignedRoutes");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "AirCrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AirLines",
                table: "AirLines");

            migrationBuilder.DropColumn(
                name: "Phones",
                table: "AirLines");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "AirLines",
                newName: "Airline");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_AirlineId",
                table: "Employee",
                newName: "IX_Employee_AirlineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airline",
                table: "Airline",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Airline_AirlineId",
                table: "Employee",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

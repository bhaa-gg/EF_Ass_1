using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Ass_1.Migrations
{
    /// <inheritdoc />
    public partial class addPhinesAirLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phones",
                table: "AirLines");

            migrationBuilder.CreateTable(
                name: "AirLinePhones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirlineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLinePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirLinePhones_AirLines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "AirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirLinePhones_AirlineId",
                table: "AirLinePhones",
                column: "AirlineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirLinePhones");

            migrationBuilder.AddColumn<string>(
                name: "Phones",
                table: "AirLines",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

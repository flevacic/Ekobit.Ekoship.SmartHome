using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ekobit.Ekoship.SmartHome.Data.Migrations
{
    public partial class Added_DeviceTypes_Units_Devices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CurrentValue = table.Column<float>(type: "real", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    HomeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Devices_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_Homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Homes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Devices_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_DeviceTypeId",
                table: "Devices",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_HomeId",
                table: "Devices",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Devices_UnitId",
                table: "Devices",
                column: "UnitId");

            migrationBuilder.InsertData(
               table: "Units",
               columns: new[] { "Id", "Name", "Symbol" },
               values: new object[,] {
                    { 1, "Celsius", "C" },
                    { 2, "Kelvin", "K" },
                    { 3, "Fahrenheit", "F" },
                    { 4, "Decibel", "dB" },
                    { 5, "Lumen", "lm" }
               });

            migrationBuilder.InsertData(
                           table: "DeviceTypes",
                           columns: new[] { "Id", "Name" },
                           values: new object[,] {
                    { 1, "Thermostat"},
                    { 2, "Drive" },
                    { 3, "Moisture meter"},
                    { 4, "Pressure gauge"},
                    { 5, "Motion sensor"},
                    { 6, "Light sensor"},
                    { 7, "Sound sensor"}
                });


            migrationBuilder.Sql(@"
            	INSERT into Devices (DeviceTypeId, Name, HomeId,IsActive,UnitId, CurrentValue, LastUpdated) values (2, 'Test device', 1, 1, 2, 0, CURRENT_TIMESTAMP)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}

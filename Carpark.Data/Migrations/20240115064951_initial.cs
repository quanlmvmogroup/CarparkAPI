using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car_park",
                columns: table => new
                {
                    CarParkNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    XCoord = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YCoord = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarParkType = table.Column<short>(type: "smallint", nullable: false),
                    TypeOfParkingSystem = table.Column<short>(type: "smallint", nullable: false),
                    CarParkDeck = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park", x => x.CarParkNo);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(551)),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(709))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "car_park_detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarParkNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShortTermParking = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    FreeParking = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    NightParking = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    GantryHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    CarParkBasement = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park_detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_car_park_detail_car_park_CarParkNo",
                        column: x => x.CarParkNo,
                        principalTable: "car_park",
                        principalColumn: "CarParkNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_favorite",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarParkNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_favorite", x => new { x.UserId, x.CarParkNo });
                    table.ForeignKey(
                        name: "FK_user_favorite_car_park_CarParkNo",
                        column: x => x.CarParkNo,
                        principalTable: "car_park",
                        principalColumn: "CarParkNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_favorite_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_park_CarParkNo",
                table: "car_park",
                column: "CarParkNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_park_detail_CarParkNo",
                table: "car_park_detail",
                column: "CarParkNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_park_detail_FreeParking",
                table: "car_park_detail",
                column: "FreeParking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_detail_GantryHeight",
                table: "car_park_detail",
                column: "GantryHeight");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_detail_NightParking",
                table: "car_park_detail",
                column: "NightParking");

            migrationBuilder.CreateIndex(
                name: "IX_user_UserName",
                table: "user",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_CarParkNo",
                table: "user_favorite",
                column: "CarParkNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_UserId",
                table: "user_favorite",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car_park_detail");

            migrationBuilder.DropTable(
                name: "user_favorite");

            migrationBuilder.DropTable(
                name: "car_park");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}

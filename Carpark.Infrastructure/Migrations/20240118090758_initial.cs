using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "car_park_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    car_park_type_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6693)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6833)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "free_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    free_parking_type_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7271)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7384)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_free_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "night_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    night_parking_type_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8556)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8665)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_night_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parking_system_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type_of_parking_system_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7892)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8004)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parking_system_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "short_term_parking_type",
                columns: table => new
                {
                    id = table.Column<short>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    short_term_parking_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9171)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9288)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_short_term_parking_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    user_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    password_hash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    password_salt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    first_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    last_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    full_name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    is_active = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: true),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(6901)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(7011)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "car_park",
                columns: table => new
                {
                    car_park_no = table.Column<string>(type: "TEXT", nullable: false),
                    address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    x_coord = table.Column<decimal>(type: "TEXT", nullable: false),
                    y_coord = table.Column<decimal>(type: "TEXT", nullable: false),
                    car_park_type = table.Column<short>(type: "INTEGER", nullable: false),
                    short_term_parking = table.Column<short>(type: "INTEGER", nullable: false),
                    car_park_decks = table.Column<short>(type: "INTEGER", nullable: false),
                    car_park_basement = table.Column<short>(type: "INTEGER", nullable: false, defaultValue: (short)0),
                    gantry_height = table.Column<decimal>(type: "TEXT", nullable: false, defaultValue: 0m),
                    free_parking = table.Column<short>(type: "INTEGER", nullable: false),
                    night_parking = table.Column<short>(type: "INTEGER", nullable: false),
                    type_of_parking_system = table.Column<short>(type: "INTEGER", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9537)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9692)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park", x => x.car_park_no);
                    table.ForeignKey(
                        name: "FK_car_park_car_park_type_car_park_type",
                        column: x => x.car_park_type,
                        principalTable: "car_park_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_free_parking_type_free_parking",
                        column: x => x.free_parking,
                        principalTable: "free_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_night_parking_type_night_parking",
                        column: x => x.night_parking,
                        principalTable: "night_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_parking_system_type_type_of_parking_system",
                        column: x => x.type_of_parking_system,
                        principalTable: "parking_system_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_car_park_short_term_parking_type_short_term_parking",
                        column: x => x.short_term_parking,
                        principalTable: "short_term_parking_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_favorite",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "TEXT", nullable: false),
                    car_park_no = table.Column<string>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3579)),
                    modified_at = table.Column<DateTime>(type: "TEXT", nullable: true, defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3967)),
                    deleted_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_favorite", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_favorite_car_park_car_park_no",
                        column: x => x.car_park_no,
                        principalTable: "car_park",
                        principalColumn: "car_park_no",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_favorite_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_park_car_park_no",
                table: "car_park",
                column: "car_park_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_car_park_car_park_type",
                table: "car_park",
                column: "car_park_type");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_free_parking",
                table: "car_park",
                column: "free_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_night_parking",
                table: "car_park",
                column: "night_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_short_term_parking",
                table: "car_park",
                column: "short_term_parking");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_type_of_parking_system",
                table: "car_park",
                column: "type_of_parking_system");

            migrationBuilder.CreateIndex(
                name: "IX_user_user_name",
                table: "user",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_car_park_no",
                table: "user_favorite",
                column: "car_park_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_favorite_user_id",
                table: "user_favorite",
                column: "user_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_favorite");

            migrationBuilder.DropTable(
                name: "car_park");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "car_park_type");

            migrationBuilder.DropTable(
                name: "free_parking_type");

            migrationBuilder.DropTable(
                name: "night_parking_type");

            migrationBuilder.DropTable(
                name: "parking_system_type");

            migrationBuilder.DropTable(
                name: "short_term_parking_type");
        }
    }
}

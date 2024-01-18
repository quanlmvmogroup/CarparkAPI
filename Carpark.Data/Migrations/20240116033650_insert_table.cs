using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class insert_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("5a82a9b3-1788-417a-87c6-21e611fb9436"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("8fc45133-a5c0-4f7f-9d50-30f03e623a4d"));

            migrationBuilder.DropColumn(
                name: "FreeParking",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "NightParking",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "ShortTermParking",
                table: "car_park");

            migrationBuilder.RenameColumn(
                name: "TypeOfParkingSystem",
                table: "car_park",
                newName: "ShortTermParkingType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.AddColumn<short>(
                name: "FreeParkingType",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NightParkingType",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ParkingTypeSystem",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "car_park_type",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarParkTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_park_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "free_parking_type",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FreeParkingTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_free_parking_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "night_parking_type",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NightParkingTypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_night_parking_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "parking_system_type",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingTypeSystemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parking_system_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "short_term_parking_type",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortTermParkingName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_short_term_parking_type", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_park_CarParkType",
                table: "car_park",
                column: "CarParkType");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_FreeParkingType",
                table: "car_park",
                column: "FreeParkingType");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_NightParkingType",
                table: "car_park",
                column: "NightParkingType");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_ParkingTypeSystem",
                table: "car_park",
                column: "ParkingTypeSystem");

            migrationBuilder.CreateIndex(
                name: "IX_car_park_ShortTermParkingType",
                table: "car_park",
                column: "ShortTermParkingType");

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_car_park_type_CarParkType",
                table: "car_park",
                column: "CarParkType",
                principalTable: "car_park_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_free_parking_type_FreeParkingType",
                table: "car_park",
                column: "FreeParkingType",
                principalTable: "free_parking_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_night_parking_type_NightParkingType",
                table: "car_park",
                column: "NightParkingType",
                principalTable: "night_parking_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_parking_system_type_ParkingTypeSystem",
                table: "car_park",
                column: "ParkingTypeSystem",
                principalTable: "parking_system_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_short_term_parking_type_ShortTermParkingType",
                table: "car_park",
                column: "ShortTermParkingType",
                principalTable: "short_term_parking_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_park_car_park_type_CarParkType",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_free_parking_type_FreeParkingType",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_night_parking_type_NightParkingType",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_parking_system_type_ParkingTypeSystem",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_short_term_parking_type_ShortTermParkingType",
                table: "car_park");

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

            migrationBuilder.DropIndex(
                name: "IX_car_park_CarParkType",
                table: "car_park");

            migrationBuilder.DropIndex(
                name: "IX_car_park_FreeParkingType",
                table: "car_park");

            migrationBuilder.DropIndex(
                name: "IX_car_park_NightParkingType",
                table: "car_park");

            migrationBuilder.DropIndex(
                name: "IX_car_park_ParkingTypeSystem",
                table: "car_park");

            migrationBuilder.DropIndex(
                name: "IX_car_park_ShortTermParkingType",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "FreeParkingType",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "NightParkingType",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "ParkingTypeSystem",
                table: "car_park");

            migrationBuilder.RenameColumn(
                name: "ShortTermParkingType",
                table: "car_park",
                newName: "TypeOfParkingSystem");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AddColumn<short>(
                name: "FreeParking",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "NightParking",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShortTermParking",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("5a82a9b3-1788-417a-87c6-21e611fb9436"), new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(858), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(858), new byte[] { 104, 138, 179, 72, 89, 35, 135, 249, 99, 35, 124, 7, 83, 93, 22, 134, 109, 44, 36, 45, 232, 219, 99, 235, 170, 21, 71, 35, 138, 50, 151, 184, 30, 227, 132, 169, 205, 201, 67, 3, 115, 70, 158, 26, 142, 209, 33, 112, 116, 116, 250, 196, 174, 83, 81, 250, 114, 110, 197, 130, 208, 180, 69, 184 }, new byte[] { 142, 134, 164, 1, 52, 58, 238, 96, 175, 146, 174, 174, 233, 9, 188, 121, 109, 67, 45, 16, 173, 215, 38, 187, 244, 169, 142, 234, 253, 222, 126, 181, 6, 204, 187, 234, 179, 112, 72, 114, 54, 140, 195, 245, 250, 229, 3, 166, 30, 177, 46, 105, 233, 221, 72, 90, 71, 148, 56, 158, 109, 81, 217, 114, 243, 143, 191, 181, 89, 167, 49, 132, 42, 102, 31, 46, 17, 244, 120, 128, 47, 92, 104, 187, 27, 143, 251, 1, 200, 10, 69, 112, 178, 213, 206, 239, 228, 43, 12, 212, 51, 171, 139, 13, 242, 19, 248, 248, 155, 2, 185, 255, 152, 94, 120, 7, 143, 97, 133, 152, 59, 82, 53, 45, 145, 132, 132, 70 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("8fc45133-a5c0-4f7f-9d50-30f03e623a4d"), new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(853), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(855), new byte[] { 104, 138, 179, 72, 89, 35, 135, 249, 99, 35, 124, 7, 83, 93, 22, 134, 109, 44, 36, 45, 232, 219, 99, 235, 170, 21, 71, 35, 138, 50, 151, 184, 30, 227, 132, 169, 205, 201, 67, 3, 115, 70, 158, 26, 142, 209, 33, 112, 116, 116, 250, 196, 174, 83, 81, 250, 114, 110, 197, 130, 208, 180, 69, 184 }, new byte[] { 142, 134, 164, 1, 52, 58, 238, 96, 175, 146, 174, 174, 233, 9, 188, 121, 109, 67, 45, 16, 173, 215, 38, 187, 244, 169, 142, 234, 253, 222, 126, 181, 6, 204, 187, 234, 179, 112, 72, 114, 54, 140, 195, 245, 250, 229, 3, 166, 30, 177, 46, 105, 233, 221, 72, 90, 71, 148, 56, 158, 109, 81, 217, 114, 243, 143, 191, 181, 89, 167, 49, 132, 42, 102, 31, 46, 17, 244, 120, 128, 47, 92, 104, 187, 27, 143, 251, 1, 200, 10, 69, 112, 178, 213, 206, 239, 228, 43, 12, 212, 51, 171, 139, 13, 242, 19, 248, 248, 155, 2, 185, 255, 152, 94, 120, 7, 143, 97, 133, 152, 59, 82, 53, 45, 145, 132, 132, 70 }, "giappq" });
        }
    }
}

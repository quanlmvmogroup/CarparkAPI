using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class remove_carpark_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car_park_detail");

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("761d22ae-40a2-4a81-9412-fd618242d44d"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("b0878ab8-f58a-43d4-8acd-ea3f51f22fcd"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "CarParkBasement",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "FreeParking",
                table: "car_park",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<decimal>(
                name: "GantryHeight",
                table: "car_park",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
                values: new object[] { new Guid("3d40169a-d305-476c-8c71-159e1c275d34"), new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9748), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9748), new byte[] { 161, 169, 129, 239, 45, 5, 48, 122, 21, 171, 52, 73, 190, 42, 126, 253, 182, 108, 118, 236, 76, 130, 19, 5, 240, 218, 62, 164, 255, 79, 142, 94, 103, 214, 142, 56, 27, 197, 128, 216, 199, 208, 250, 174, 131, 22, 228, 40, 68, 182, 69, 124, 139, 143, 82, 78, 63, 206, 192, 105, 141, 197, 208, 237, 198, 6, 201, 189, 198, 103, 204, 245, 245, 213, 247, 177, 53, 0, 162, 62, 190, 245, 32, 235, 202, 35, 67, 68, 221, 33, 127, 147, 217, 177, 27, 237, 247, 247, 77, 9, 50, 107, 97, 142, 236, 76, 39, 155, 147, 39, 37, 79, 243, 250, 80, 48, 126, 61, 136, 156, 225, 207, 131, 43, 245, 230, 17, 194 }, new byte[] { 242, 252, 255, 170, 167, 245, 99, 202, 91, 29, 181, 33, 118, 136, 225, 153, 235, 67, 19, 244, 44, 75, 109, 162, 12, 192, 16, 241, 19, 94, 253, 223, 252, 50, 24, 197, 46, 107, 174, 130, 119, 251, 227, 220, 94, 11, 240, 62, 213, 65, 55, 174, 201, 120, 48, 83, 27, 105, 184, 214, 110, 145, 36, 220 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("868e4f5e-bdf5-4b3b-9209-df11cc7e53ee"), new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9743), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9745), new byte[] { 161, 169, 129, 239, 45, 5, 48, 122, 21, 171, 52, 73, 190, 42, 126, 253, 182, 108, 118, 236, 76, 130, 19, 5, 240, 218, 62, 164, 255, 79, 142, 94, 103, 214, 142, 56, 27, 197, 128, 216, 199, 208, 250, 174, 131, 22, 228, 40, 68, 182, 69, 124, 139, 143, 82, 78, 63, 206, 192, 105, 141, 197, 208, 237, 198, 6, 201, 189, 198, 103, 204, 245, 245, 213, 247, 177, 53, 0, 162, 62, 190, 245, 32, 235, 202, 35, 67, 68, 221, 33, 127, 147, 217, 177, 27, 237, 247, 247, 77, 9, 50, 107, 97, 142, 236, 76, 39, 155, 147, 39, 37, 79, 243, 250, 80, 48, 126, 61, 136, 156, 225, 207, 131, 43, 245, 230, 17, 194 }, new byte[] { 242, 252, 255, 170, 167, 245, 99, 202, 91, 29, 181, 33, 118, 136, 225, 153, 235, 67, 19, 244, 44, 75, 109, 162, 12, 192, 16, 241, 19, 94, 253, 223, 252, 50, 24, 197, 46, 107, 174, 130, 119, 251, 227, 220, 94, 11, 240, 62, 213, 65, 55, 174, 201, 120, 48, 83, 27, 105, 184, 214, 110, 145, 36, 220 }, "giappq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("3d40169a-d305-476c-8c71-159e1c275d34"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("868e4f5e-bdf5-4b3b-9209-df11cc7e53ee"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "user");

            migrationBuilder.DropColumn(
                name: "CarParkBasement",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "FreeParking",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "GantryHeight",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "NightParking",
                table: "car_park");

            migrationBuilder.DropColumn(
                name: "ShortTermParking",
                table: "car_park");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.CreateTable(
                name: "car_park_detail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarParkNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarParkBasement = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    FreeParking = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    GantryHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    NightParking = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    ShortTermParking = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
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

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("761d22ae-40a2-4a81-9412-fd618242d44d"), new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3452), "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3455), new byte[] { 11, 231, 75, 93, 20, 118, 100, 134, 29, 37, 239, 160, 34, 255, 230, 66, 220, 9, 198, 14, 83, 216, 12, 195, 204, 212, 239, 62, 93, 158, 109, 152, 209, 88, 233, 122, 67, 51, 202, 56, 103, 86, 72, 41, 73, 35, 206, 200, 64, 253, 222, 106, 149, 100, 158, 194, 200, 145, 17, 82, 174, 195, 250, 182, 33, 225, 236, 213, 4, 42, 214, 130, 21, 40, 163, 53, 93, 98, 185, 188, 175, 95, 143, 39, 213, 214, 105, 150, 70, 247, 88, 126, 100, 39, 179, 141, 205, 119, 50, 121, 102, 45, 150, 230, 6, 240, 33, 166, 10, 120, 159, 115, 210, 38, 26, 206, 65, 233, 111, 41, 237, 18, 213, 67, 65, 9, 20, 195 }, new byte[] { 98, 13, 115, 82, 254, 129, 253, 51, 131, 252, 130, 185, 5, 154, 77, 66, 238, 249, 247, 189, 18, 188, 162, 100, 226, 63, 97, 163, 102, 168, 121, 34, 198, 216, 161, 177, 212, 218, 116, 233, 117, 166, 22, 93, 140, 194, 23, 251, 60, 223, 244, 21, 150, 8, 104, 45, 20, 169, 57, 246, 91, 84, 166, 117 }, "giappq" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("b0878ab8-f58a-43d4-8acd-ea3f51f22fcd"), new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3457), "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3457), new byte[] { 11, 231, 75, 93, 20, 118, 100, 134, 29, 37, 239, 160, 34, 255, 230, 66, 220, 9, 198, 14, 83, 216, 12, 195, 204, 212, 239, 62, 93, 158, 109, 152, 209, 88, 233, 122, 67, 51, 202, 56, 103, 86, 72, 41, 73, 35, 206, 200, 64, 253, 222, 106, 149, 100, 158, 194, 200, 145, 17, 82, 174, 195, 250, 182, 33, 225, 236, 213, 4, 42, 214, 130, 21, 40, 163, 53, 93, 98, 185, 188, 175, 95, 143, 39, 213, 214, 105, 150, 70, 247, 88, 126, 100, 39, 179, 141, 205, 119, 50, 121, 102, 45, 150, 230, 6, 240, 33, 166, 10, 120, 159, 115, 210, 38, 26, 206, 65, 233, 111, 41, 237, 18, 213, 67, 65, 9, 20, 195 }, new byte[] { 98, 13, 115, 82, 254, 129, 253, 51, 131, 252, 130, 185, 5, 154, 77, 66, 238, 249, 247, 189, 18, 188, 162, 100, 226, 63, 97, 163, 102, 168, 121, 34, 198, 216, 161, 177, 212, 218, 116, 233, 117, 166, 22, 93, 140, 194, 23, 251, 60, 223, 244, 21, 150, 8, 104, 45, 20, 169, 57, 246, 91, 84, 166, 117 }, "giappq1" });

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
        }
    }
}

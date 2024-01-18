using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class user_data_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("761d22ae-40a2-4a81-9412-fd618242d44d"), new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3452), "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3455), new byte[] { 11, 231, 75, 93, 20, 118, 100, 134, 29, 37, 239, 160, 34, 255, 230, 66, 220, 9, 198, 14, 83, 216, 12, 195, 204, 212, 239, 62, 93, 158, 109, 152, 209, 88, 233, 122, 67, 51, 202, 56, 103, 86, 72, 41, 73, 35, 206, 200, 64, 253, 222, 106, 149, 100, 158, 194, 200, 145, 17, 82, 174, 195, 250, 182, 33, 225, 236, 213, 4, 42, 214, 130, 21, 40, 163, 53, 93, 98, 185, 188, 175, 95, 143, 39, 213, 214, 105, 150, 70, 247, 88, 126, 100, 39, 179, 141, 205, 119, 50, 121, 102, 45, 150, 230, 6, 240, 33, 166, 10, 120, 159, 115, 210, 38, 26, 206, 65, 233, 111, 41, 237, 18, 213, 67, 65, 9, 20, 195 }, new byte[] { 98, 13, 115, 82, 254, 129, 253, 51, 131, 252, 130, 185, 5, 154, 77, 66, 238, 249, 247, 189, 18, 188, 162, 100, 226, 63, 97, 163, 102, 168, 121, 34, 198, 216, 161, 177, 212, 218, 116, 233, 117, 166, 22, 93, 140, 194, 23, 251, 60, 223, 244, 21, 150, 8, 104, 45, 20, 169, 57, 246, 91, 84, 166, 117 }, "giappq" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("b0878ab8-f58a-43d4-8acd-ea3f51f22fcd"), new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3457), "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 8, 52, 26, 687, DateTimeKind.Utc).AddTicks(3457), new byte[] { 11, 231, 75, 93, 20, 118, 100, 134, 29, 37, 239, 160, 34, 255, 230, 66, 220, 9, 198, 14, 83, 216, 12, 195, 204, 212, 239, 62, 93, 158, 109, 152, 209, 88, 233, 122, 67, 51, 202, 56, 103, 86, 72, 41, 73, 35, 206, 200, 64, 253, 222, 106, 149, 100, 158, 194, 200, 145, 17, 82, 174, 195, 250, 182, 33, 225, 236, 213, 4, 42, 214, 130, 21, 40, 163, 53, 93, 98, 185, 188, 175, 95, 143, 39, 213, 214, 105, 150, 70, 247, 88, 126, 100, 39, 179, 141, 205, 119, 50, 121, 102, 45, 150, 230, 6, 240, 33, 166, 10, 120, 159, 115, 210, 38, 26, 206, 65, 233, 111, 41, 237, 18, 213, 67, 65, 9, 20, 195 }, new byte[] { 98, 13, 115, 82, 254, 129, 253, 51, 131, 252, 130, 185, 5, 154, 77, 66, 238, 249, 247, 189, 18, 188, 162, 100, 226, 63, 97, 163, 102, 168, 121, 34, 198, 216, 161, 177, 212, 218, 116, 233, 117, 166, 22, 93, 140, 194, 23, 251, 60, 223, 244, 21, 150, 8, 104, 45, 20, 169, 57, 246, 91, 84, 166, 117 }, "giappq1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                defaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 52, 26, 685, DateTimeKind.Utc).AddTicks(1459));
        }
    }
}

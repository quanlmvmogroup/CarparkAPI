using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("a4acd67d-1861-4ea3-a464-fd4b0e35777f"), new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9999), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9999), new byte[] { 72, 40, 43, 170, 247, 141, 160, 226, 157, 155, 19, 235, 172, 205, 186, 183, 42, 50, 101, 208, 123, 185, 111, 60, 59, 180, 88, 171, 189, 246, 228, 175, 187, 231, 135, 50, 32, 96, 149, 123, 121, 62, 202, 45, 69, 130, 244, 139, 214, 178, 186, 27, 218, 253, 173, 221, 184, 25, 176, 17, 222, 229, 70, 152 }, new byte[] { 135, 147, 198, 89, 188, 100, 100, 36, 121, 202, 103, 205, 87, 239, 49, 56, 116, 91, 108, 97, 244, 67, 124, 156, 79, 224, 108, 243, 34, 92, 191, 188, 141, 230, 185, 224, 188, 163, 170, 131, 244, 5, 119, 200, 146, 147, 96, 33, 208, 75, 16, 98, 8, 171, 82, 154, 44, 41, 235, 247, 41, 179, 195, 254, 165, 102, 139, 230, 82, 49, 190, 209, 99, 23, 133, 202, 76, 21, 214, 56, 13, 125, 86, 134, 148, 235, 182, 161, 121, 9, 227, 226, 230, 253, 197, 236, 201, 146, 217, 29, 129, 209, 175, 16, 248, 135, 73, 141, 185, 35, 134, 173, 147, 112, 176, 149, 159, 164, 112, 194, 188, 3, 159, 44, 53, 97, 113, 239 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("dd670c40-7bbd-4e8b-ae27-a73a37a6d49a"), new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9994), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9996), new byte[] { 72, 40, 43, 170, 247, 141, 160, 226, 157, 155, 19, 235, 172, 205, 186, 183, 42, 50, 101, 208, 123, 185, 111, 60, 59, 180, 88, 171, 189, 246, 228, 175, 187, 231, 135, 50, 32, 96, 149, 123, 121, 62, 202, 45, 69, 130, 244, 139, 214, 178, 186, 27, 218, 253, 173, 221, 184, 25, 176, 17, 222, 229, 70, 152 }, new byte[] { 135, 147, 198, 89, 188, 100, 100, 36, 121, 202, 103, 205, 87, 239, 49, 56, 116, 91, 108, 97, 244, 67, 124, 156, 79, 224, 108, 243, 34, 92, 191, 188, 141, 230, 185, 224, 188, 163, 170, 131, 244, 5, 119, 200, 146, 147, 96, 33, 208, 75, 16, 98, 8, 171, 82, 154, 44, 41, 235, 247, 41, 179, 195, 254, 165, 102, 139, 230, 82, 49, 190, 209, 99, 23, 133, 202, 76, 21, 214, 56, 13, 125, 86, 134, 148, 235, 182, 161, 121, 9, 227, 226, 230, 253, 197, 236, 201, 146, 217, 29, 129, 209, 175, 16, 248, 135, 73, 141, 185, 35, 134, 173, 147, 112, 176, 149, 159, 164, 112, 194, 188, 3, 159, 44, 53, 97, 113, 239 }, "giappq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("a4acd67d-1861-4ea3-a464-fd4b0e35777f"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("dd670c40-7bbd-4e8b-ae27-a73a37a6d49a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5653));
        }
    }
}

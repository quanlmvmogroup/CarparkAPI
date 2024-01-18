using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class removeuserfavoriteprimarykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_favorite",
                table: "user_favorite");

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
                defaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(6081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(5918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_favorite",
                table: "user_favorite",
                column: "user_id");

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("045485cd-6feb-40fa-b713-8ae1399b5290"), new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(133), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(135), new byte[] { 171, 179, 182, 214, 209, 140, 219, 61, 30, 225, 78, 225, 32, 62, 67, 171, 229, 79, 202, 79, 177, 127, 36, 197, 146, 116, 154, 250, 158, 255, 23, 107, 106, 27, 31, 247, 207, 43, 32, 234, 34, 152, 46, 118, 237, 169, 60, 61, 178, 159, 175, 115, 119, 117, 224, 5, 28, 183, 73, 129, 92, 140, 228, 204 }, new byte[] { 226, 114, 174, 97, 209, 31, 183, 153, 161, 95, 132, 148, 137, 98, 172, 185, 42, 237, 198, 58, 181, 84, 240, 190, 255, 98, 236, 221, 111, 29, 22, 189, 190, 241, 195, 202, 254, 62, 111, 167, 214, 12, 86, 187, 128, 1, 215, 119, 131, 53, 100, 26, 87, 69, 143, 0, 221, 203, 212, 4, 33, 121, 70, 186, 91, 170, 70, 126, 146, 53, 198, 168, 99, 255, 83, 253, 114, 129, 192, 178, 187, 91, 87, 1, 138, 251, 128, 195, 24, 143, 215, 104, 48, 110, 82, 39, 248, 219, 96, 42, 120, 222, 79, 82, 156, 47, 252, 47, 135, 232, 242, 107, 89, 130, 119, 215, 194, 229, 114, 208, 143, 237, 160, 18, 100, 128, 253, 157 }, "giappq" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("ee4d9404-4c90-4624-8803-2efd316cb923"), new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(138), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(138), new byte[] { 171, 179, 182, 214, 209, 140, 219, 61, 30, 225, 78, 225, 32, 62, 67, 171, 229, 79, 202, 79, 177, 127, 36, 197, 146, 116, 154, 250, 158, 255, 23, 107, 106, 27, 31, 247, 207, 43, 32, 234, 34, 152, 46, 118, 237, 169, 60, 61, 178, 159, 175, 115, 119, 117, 224, 5, 28, 183, 73, 129, 92, 140, 228, 204 }, new byte[] { 226, 114, 174, 97, 209, 31, 183, 153, 161, 95, 132, 148, 137, 98, 172, 185, 42, 237, 198, 58, 181, 84, 240, 190, 255, 98, 236, 221, 111, 29, 22, 189, 190, 241, 195, 202, 254, 62, 111, 167, 214, 12, 86, 187, 128, 1, 215, 119, 131, 53, 100, 26, 87, 69, 143, 0, 221, 203, 212, 4, 33, 121, 70, 186, 91, 170, 70, 126, 146, 53, 198, 168, 99, 255, 83, 253, 114, 129, 192, 178, 187, 91, 87, 1, 138, 251, 128, 195, 24, 143, 215, 104, 48, 110, 82, 39, 248, 219, 96, 42, 120, 222, 79, 82, 156, 47, 252, 47, 135, 232, 242, 107, 89, 130, 119, 215, 194, 229, 114, 208, 143, 237, 160, 18, 100, 128, 253, 157 }, "giappq1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user_favorite",
                table: "user_favorite");

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("045485cd-6feb-40fa-b713-8ae1399b5290"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("ee4d9404-4c90-4624-8803-2efd316cb923"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 4, 47, 931, DateTimeKind.Utc).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_favorite",
                table: "user_favorite",
                columns: new[] { "user_id", "car_park_no" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("a4acd67d-1861-4ea3-a464-fd4b0e35777f"), new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9999), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9999), new byte[] { 72, 40, 43, 170, 247, 141, 160, 226, 157, 155, 19, 235, 172, 205, 186, 183, 42, 50, 101, 208, 123, 185, 111, 60, 59, 180, 88, 171, 189, 246, 228, 175, 187, 231, 135, 50, 32, 96, 149, 123, 121, 62, 202, 45, 69, 130, 244, 139, 214, 178, 186, 27, 218, 253, 173, 221, 184, 25, 176, 17, 222, 229, 70, 152 }, new byte[] { 135, 147, 198, 89, 188, 100, 100, 36, 121, 202, 103, 205, 87, 239, 49, 56, 116, 91, 108, 97, 244, 67, 124, 156, 79, 224, 108, 243, 34, 92, 191, 188, 141, 230, 185, 224, 188, 163, 170, 131, 244, 5, 119, 200, 146, 147, 96, 33, 208, 75, 16, 98, 8, 171, 82, 154, 44, 41, 235, 247, 41, 179, 195, 254, 165, 102, 139, 230, 82, 49, 190, 209, 99, 23, 133, 202, 76, 21, 214, 56, 13, 125, 86, 134, 148, 235, 182, 161, 121, 9, 227, 226, 230, 253, 197, 236, 201, 146, 217, 29, 129, 209, 175, 16, 248, 135, 73, 141, 185, 35, 134, 173, 147, 112, 176, 149, 159, 164, 112, 194, 188, 3, 159, 44, 53, 97, 113, 239 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("dd670c40-7bbd-4e8b-ae27-a73a37a6d49a"), new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9994), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 16, 10, 4, 47, 935, DateTimeKind.Utc).AddTicks(9996), new byte[] { 72, 40, 43, 170, 247, 141, 160, 226, 157, 155, 19, 235, 172, 205, 186, 183, 42, 50, 101, 208, 123, 185, 111, 60, 59, 180, 88, 171, 189, 246, 228, 175, 187, 231, 135, 50, 32, 96, 149, 123, 121, 62, 202, 45, 69, 130, 244, 139, 214, 178, 186, 27, 218, 253, 173, 221, 184, 25, 176, 17, 222, 229, 70, 152 }, new byte[] { 135, 147, 198, 89, 188, 100, 100, 36, 121, 202, 103, 205, 87, 239, 49, 56, 116, 91, 108, 97, 244, 67, 124, 156, 79, 224, 108, 243, 34, 92, 191, 188, 141, 230, 185, 224, 188, 163, 170, 131, 244, 5, 119, 200, 146, 147, 96, 33, 208, 75, 16, 98, 8, 171, 82, 154, 44, 41, 235, 247, 41, 179, 195, 254, 165, 102, 139, 230, 82, 49, 190, 209, 99, 23, 133, 202, 76, 21, 214, 56, 13, 125, 86, 134, 148, 235, 182, 161, 121, 9, 227, 226, 230, 253, 197, 236, 201, 146, 217, 29, 129, 209, 175, 16, 248, 135, 73, 141, 185, 35, 134, 173, 147, 112, 176, 149, 159, 164, 112, 194, 188, 3, 159, 44, 53, 97, 113, 239 }, "giappq" });
        }
    }
}

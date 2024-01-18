using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class change_column_name_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("4f69b271-42fb-493d-aad7-9ece2cf16918"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("715a2a34-0ca8-4f1b-b7ae-68ffdbbfdbf6"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 24, 22, 419, DateTimeKind.Utc).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 24, 22, 419, DateTimeKind.Utc).AddTicks(8155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("1ae5bf5f-a8f5-457d-bac4-a9f63667742c"), new DateTime(2024, 1, 18, 3, 24, 22, 423, DateTimeKind.Utc).AddTicks(368), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 18, 3, 24, 22, 423, DateTimeKind.Utc).AddTicks(368), new byte[] { 187, 143, 30, 203, 192, 20, 77, 71, 206, 52, 17, 131, 111, 200, 152, 95, 192, 163, 18, 196, 182, 193, 20, 95, 65, 32, 240, 28, 7, 248, 145, 182, 3, 187, 73, 225, 198, 40, 122, 175, 16, 95, 251, 57, 40, 224, 136, 216, 104, 90, 207, 108, 136, 108, 108, 247, 155, 178, 95, 31, 222, 82, 213, 238 }, new byte[] { 188, 251, 121, 49, 201, 105, 71, 252, 28, 92, 26, 220, 99, 89, 59, 112, 177, 153, 252, 127, 43, 208, 205, 26, 149, 138, 255, 44, 232, 2, 21, 150, 173, 160, 12, 21, 164, 137, 142, 126, 80, 19, 205, 18, 238, 28, 163, 83, 121, 219, 166, 183, 159, 76, 81, 113, 218, 52, 122, 184, 113, 11, 138, 189, 36, 96, 110, 191, 150, 150, 18, 160, 112, 186, 54, 8, 153, 171, 115, 53, 86, 49, 226, 162, 2, 178, 84, 234, 244, 33, 121, 64, 26, 100, 255, 223, 146, 226, 227, 249, 233, 18, 233, 138, 80, 241, 110, 3, 196, 157, 28, 142, 167, 5, 180, 49, 48, 181, 236, 249, 134, 33, 159, 170, 229, 114, 234, 227 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("22b85f84-cbef-4364-94f5-547223c02dac"), new DateTime(2024, 1, 18, 3, 24, 22, 423, DateTimeKind.Utc).AddTicks(362), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 18, 3, 24, 22, 423, DateTimeKind.Utc).AddTicks(366), new byte[] { 187, 143, 30, 203, 192, 20, 77, 71, 206, 52, 17, 131, 111, 200, 152, 95, 192, 163, 18, 196, 182, 193, 20, 95, 65, 32, 240, 28, 7, 248, 145, 182, 3, 187, 73, 225, 198, 40, 122, 175, 16, 95, 251, 57, 40, 224, 136, 216, 104, 90, 207, 108, 136, 108, 108, 247, 155, 178, 95, 31, 222, 82, 213, 238 }, new byte[] { 188, 251, 121, 49, 201, 105, 71, 252, 28, 92, 26, 220, 99, 89, 59, 112, 177, 153, 252, 127, 43, 208, 205, 26, 149, 138, 255, 44, 232, 2, 21, 150, 173, 160, 12, 21, 164, 137, 142, 126, 80, 19, 205, 18, 238, 28, 163, 83, 121, 219, 166, 183, 159, 76, 81, 113, 218, 52, 122, 184, 113, 11, 138, 189, 36, 96, 110, 191, 150, 150, 18, 160, 112, 186, 54, 8, 153, 171, 115, 53, 86, 49, 226, 162, 2, 178, 84, 234, 244, 33, 121, 64, 26, 100, 255, 223, 146, 226, 227, 249, 233, 18, 233, 138, 80, 241, 110, 3, 196, 157, 28, 142, 167, 5, 180, 49, 48, 181, 236, 249, 134, 33, 159, 170, 229, 114, 234, 227 }, "giappq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("1ae5bf5f-a8f5-457d-bac4-a9f63667742c"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("22b85f84-cbef-4364-94f5-547223c02dac"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 24, 22, 419, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 24, 22, 419, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("4f69b271-42fb-493d-aad7-9ece2cf16918"), new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5939), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5939), new byte[] { 41, 128, 124, 102, 108, 148, 76, 245, 241, 96, 222, 229, 220, 183, 39, 187, 204, 37, 90, 210, 193, 107, 71, 152, 143, 186, 195, 18, 24, 216, 152, 245, 106, 117, 112, 207, 200, 145, 85, 10, 91, 157, 141, 10, 45, 86, 227, 172, 108, 50, 49, 161, 224, 119, 87, 254, 145, 22, 141, 208, 159, 124, 150, 232 }, new byte[] { 145, 130, 48, 20, 35, 209, 105, 230, 2, 212, 64, 122, 115, 22, 29, 195, 50, 38, 104, 88, 29, 34, 200, 212, 72, 163, 38, 142, 110, 31, 43, 14, 75, 2, 21, 8, 205, 87, 83, 50, 231, 155, 178, 67, 124, 252, 57, 227, 180, 171, 166, 176, 67, 132, 164, 209, 214, 56, 14, 241, 212, 9, 163, 73, 232, 251, 162, 102, 140, 247, 92, 17, 248, 115, 48, 90, 67, 252, 166, 191, 108, 65, 9, 221, 83, 147, 84, 106, 165, 197, 154, 86, 101, 64, 72, 230, 72, 242, 134, 29, 41, 93, 104, 255, 251, 70, 238, 21, 114, 135, 135, 41, 221, 197, 104, 174, 18, 104, 189, 70, 86, 18, 116, 189, 164, 249, 239, 24 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("715a2a34-0ca8-4f1b-b7ae-68ffdbbfdbf6"), new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5922), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5925), new byte[] { 41, 128, 124, 102, 108, 148, 76, 245, 241, 96, 222, 229, 220, 183, 39, 187, 204, 37, 90, 210, 193, 107, 71, 152, 143, 186, 195, 18, 24, 216, 152, 245, 106, 117, 112, 207, 200, 145, 85, 10, 91, 157, 141, 10, 45, 86, 227, 172, 108, 50, 49, 161, 224, 119, 87, 254, 145, 22, 141, 208, 159, 124, 150, 232 }, new byte[] { 145, 130, 48, 20, 35, 209, 105, 230, 2, 212, 64, 122, 115, 22, 29, 195, 50, 38, 104, 88, 29, 34, 200, 212, 72, 163, 38, 142, 110, 31, 43, 14, 75, 2, 21, 8, 205, 87, 83, 50, 231, 155, 178, 67, 124, 252, 57, 227, 180, 171, 166, 176, 67, 132, 164, 209, 214, 56, 14, 241, 212, 9, 163, 73, 232, 251, 162, 102, 140, 247, 92, 17, 248, 115, 48, 90, 67, 252, 166, 191, 108, 65, 9, 221, 83, 147, 84, 106, 165, 197, 154, 86, 101, 64, 72, 230, 72, 242, 134, 29, 41, 93, 104, 255, 251, 70, 238, 21, 114, 135, 135, 41, 221, 197, 104, 174, 18, 104, 189, 70, 86, 18, 116, 189, 164, 249, 239, 24 }, "giappq" });
        }
    }
}

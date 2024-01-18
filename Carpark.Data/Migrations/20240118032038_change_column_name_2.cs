using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class change_column_name_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("045485cd-6feb-40fa-b713-8ae1399b5290"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("ee4d9404-4c90-4624-8803-2efd316cb923"));

            migrationBuilder.RenameColumn(
                name: "ganny_height",
                table: "car_park",
                newName: "gantry_height");

            migrationBuilder.RenameColumn(
                name: "car_park_basements",
                table: "car_park",
                newName: "car_park_basement");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("4f69b271-42fb-493d-aad7-9ece2cf16918"), new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5939), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5939), new byte[] { 41, 128, 124, 102, 108, 148, 76, 245, 241, 96, 222, 229, 220, 183, 39, 187, 204, 37, 90, 210, 193, 107, 71, 152, 143, 186, 195, 18, 24, 216, 152, 245, 106, 117, 112, 207, 200, 145, 85, 10, 91, 157, 141, 10, 45, 86, 227, 172, 108, 50, 49, 161, 224, 119, 87, 254, 145, 22, 141, 208, 159, 124, 150, 232 }, new byte[] { 145, 130, 48, 20, 35, 209, 105, 230, 2, 212, 64, 122, 115, 22, 29, 195, 50, 38, 104, 88, 29, 34, 200, 212, 72, 163, 38, 142, 110, 31, 43, 14, 75, 2, 21, 8, 205, 87, 83, 50, 231, 155, 178, 67, 124, 252, 57, 227, 180, 171, 166, 176, 67, 132, 164, 209, 214, 56, 14, 241, 212, 9, 163, 73, 232, 251, 162, 102, 140, 247, 92, 17, 248, 115, 48, 90, 67, 252, 166, 191, 108, 65, 9, 221, 83, 147, 84, 106, 165, 197, 154, 86, 101, 64, 72, 230, 72, 242, 134, 29, 41, 93, 104, 255, 251, 70, 238, 21, 114, 135, 135, 41, 221, 197, 104, 174, 18, 104, 189, 70, 86, 18, 116, 189, 164, 249, 239, 24 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("715a2a34-0ca8-4f1b-b7ae-68ffdbbfdbf6"), new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5922), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 18, 3, 20, 38, 544, DateTimeKind.Utc).AddTicks(5925), new byte[] { 41, 128, 124, 102, 108, 148, 76, 245, 241, 96, 222, 229, 220, 183, 39, 187, 204, 37, 90, 210, 193, 107, 71, 152, 143, 186, 195, 18, 24, 216, 152, 245, 106, 117, 112, 207, 200, 145, 85, 10, 91, 157, 141, 10, 45, 86, 227, 172, 108, 50, 49, 161, 224, 119, 87, 254, 145, 22, 141, 208, 159, 124, 150, 232 }, new byte[] { 145, 130, 48, 20, 35, 209, 105, 230, 2, 212, 64, 122, 115, 22, 29, 195, 50, 38, 104, 88, 29, 34, 200, 212, 72, 163, 38, 142, 110, 31, 43, 14, 75, 2, 21, 8, 205, 87, 83, 50, 231, 155, 178, 67, 124, 252, 57, 227, 180, 171, 166, 176, 67, 132, 164, 209, 214, 56, 14, 241, 212, 9, 163, 73, 232, 251, 162, 102, 140, 247, 92, 17, 248, 115, 48, 90, 67, 252, 166, 191, 108, 65, 9, 221, 83, 147, 84, 106, 165, 197, 154, 86, 101, 64, 72, 230, 72, 242, 134, 29, 41, 93, 104, 255, 251, 70, 238, 21, 114, 135, 135, 41, 221, 197, 104, 174, 18, 104, 189, 70, 86, 18, 116, 189, 164, 249, 239, 24 }, "giappq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("4f69b271-42fb-493d-aad7-9ece2cf16918"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("715a2a34-0ca8-4f1b-b7ae-68ffdbbfdbf6"));

            migrationBuilder.RenameColumn(
                name: "gantry_height",
                table: "car_park",
                newName: "ganny_height");

            migrationBuilder.RenameColumn(
                name: "car_park_basement",
                table: "car_park",
                newName: "car_park_basements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(6081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 17, 5, 32, 58, 139, DateTimeKind.Utc).AddTicks(5918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 3, 20, 38, 541, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("045485cd-6feb-40fa-b713-8ae1399b5290"), new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(133), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(135), new byte[] { 171, 179, 182, 214, 209, 140, 219, 61, 30, 225, 78, 225, 32, 62, 67, 171, 229, 79, 202, 79, 177, 127, 36, 197, 146, 116, 154, 250, 158, 255, 23, 107, 106, 27, 31, 247, 207, 43, 32, 234, 34, 152, 46, 118, 237, 169, 60, 61, 178, 159, 175, 115, 119, 117, 224, 5, 28, 183, 73, 129, 92, 140, 228, 204 }, new byte[] { 226, 114, 174, 97, 209, 31, 183, 153, 161, 95, 132, 148, 137, 98, 172, 185, 42, 237, 198, 58, 181, 84, 240, 190, 255, 98, 236, 221, 111, 29, 22, 189, 190, 241, 195, 202, 254, 62, 111, 167, 214, 12, 86, 187, 128, 1, 215, 119, 131, 53, 100, 26, 87, 69, 143, 0, 221, 203, 212, 4, 33, 121, 70, 186, 91, 170, 70, 126, 146, 53, 198, 168, 99, 255, 83, 253, 114, 129, 192, 178, 187, 91, 87, 1, 138, 251, 128, 195, 24, 143, 215, 104, 48, 110, 82, 39, 248, 219, 96, 42, 120, 222, 79, 82, 156, 47, 252, 47, 135, 232, 242, 107, 89, 130, 119, 215, 194, 229, 114, 208, 143, 237, 160, 18, 100, 128, 253, 157 }, "giappq" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created", "email", "first_name", "full_name", "is_active", "last_name", "modified", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("ee4d9404-4c90-4624-8803-2efd316cb923"), new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(138), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 17, 5, 32, 58, 143, DateTimeKind.Utc).AddTicks(138), new byte[] { 171, 179, 182, 214, 209, 140, 219, 61, 30, 225, 78, 225, 32, 62, 67, 171, 229, 79, 202, 79, 177, 127, 36, 197, 146, 116, 154, 250, 158, 255, 23, 107, 106, 27, 31, 247, 207, 43, 32, 234, 34, 152, 46, 118, 237, 169, 60, 61, 178, 159, 175, 115, 119, 117, 224, 5, 28, 183, 73, 129, 92, 140, 228, 204 }, new byte[] { 226, 114, 174, 97, 209, 31, 183, 153, 161, 95, 132, 148, 137, 98, 172, 185, 42, 237, 198, 58, 181, 84, 240, 190, 255, 98, 236, 221, 111, 29, 22, 189, 190, 241, 195, 202, 254, 62, 111, 167, 214, 12, 86, 187, 128, 1, 215, 119, 131, 53, 100, 26, 87, 69, 143, 0, 221, 203, 212, 4, 33, 121, 70, 186, 91, 170, 70, 126, 146, 53, 198, 168, 99, 255, 83, 253, 114, 129, 192, 178, 187, 91, 87, 1, 138, 251, 128, 195, 24, 143, 215, 104, 48, 110, 82, 39, 248, 219, 96, 42, 120, 222, 79, 82, 156, 47, 252, 47, 135, 232, 242, 107, 89, 130, 119, 215, 194, 229, 114, 208, 143, 237, 160, 18, 100, 128, 253, 157 }, "giappq1" });
        }
    }
}

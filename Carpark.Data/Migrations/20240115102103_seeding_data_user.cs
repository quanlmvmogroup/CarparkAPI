using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class seeding_data_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("3d40169a-d305-476c-8c71-159e1c275d34"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("868e4f5e-bdf5-4b3b-9209-df11cc7e53ee"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("5a82a9b3-1788-417a-87c6-21e611fb9436"), new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(858), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(858), new byte[] { 104, 138, 179, 72, 89, 35, 135, 249, 99, 35, 124, 7, 83, 93, 22, 134, 109, 44, 36, 45, 232, 219, 99, 235, 170, 21, 71, 35, 138, 50, 151, 184, 30, 227, 132, 169, 205, 201, 67, 3, 115, 70, 158, 26, 142, 209, 33, 112, 116, 116, 250, 196, 174, 83, 81, 250, 114, 110, 197, 130, 208, 180, 69, 184 }, new byte[] { 142, 134, 164, 1, 52, 58, 238, 96, 175, 146, 174, 174, 233, 9, 188, 121, 109, 67, 45, 16, 173, 215, 38, 187, 244, 169, 142, 234, 253, 222, 126, 181, 6, 204, 187, 234, 179, 112, 72, 114, 54, 140, 195, 245, 250, 229, 3, 166, 30, 177, 46, 105, 233, 221, 72, 90, 71, 148, 56, 158, 109, 81, 217, 114, 243, 143, 191, 181, 89, 167, 49, 132, 42, 102, 31, 46, 17, 244, 120, 128, 47, 92, 104, 187, 27, 143, 251, 1, 200, 10, 69, 112, 178, 213, 206, 239, 228, 43, 12, 212, 51, 171, 139, 13, 242, 19, 248, 248, 155, 2, 185, 255, 152, 94, 120, 7, 143, 97, 133, 152, 59, 82, 53, 45, 145, 132, 132, 70 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("8fc45133-a5c0-4f7f-9d50-30f03e623a4d"), new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(853), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 10, 21, 3, 332, DateTimeKind.Utc).AddTicks(855), new byte[] { 104, 138, 179, 72, 89, 35, 135, 249, 99, 35, 124, 7, 83, 93, 22, 134, 109, 44, 36, 45, 232, 219, 99, 235, 170, 21, 71, 35, 138, 50, 151, 184, 30, 227, 132, 169, 205, 201, 67, 3, 115, 70, 158, 26, 142, 209, 33, 112, 116, 116, 250, 196, 174, 83, 81, 250, 114, 110, 197, 130, 208, 180, 69, 184 }, new byte[] { 142, 134, 164, 1, 52, 58, 238, 96, 175, 146, 174, 174, 233, 9, 188, 121, 109, 67, 45, 16, 173, 215, 38, 187, 244, 169, 142, 234, 253, 222, 126, 181, 6, 204, 187, 234, 179, 112, 72, 114, 54, 140, 195, 245, 250, 229, 3, 166, 30, 177, 46, 105, 233, 221, 72, 90, 71, 148, 56, 158, 109, 81, 217, 114, 243, 143, 191, 181, 89, 167, 49, 132, 42, 102, 31, 46, 17, 244, 120, 128, 47, 92, 104, 187, 27, 143, 251, 1, 200, 10, 69, 112, 178, 213, 206, 239, 228, 43, 12, 212, 51, 171, 139, 13, 242, 19, 248, 248, 155, 2, 185, 255, 152, 94, 120, 7, 143, 97, 133, 152, 59, 82, 53, 45, 145, 132, 132, 70 }, "giappq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("5a82a9b3-1788-417a-87c6-21e611fb9436"));

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "Id",
                keyValue: new Guid("8fc45133-a5c0-4f7f-9d50-30f03e623a4d"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 9, 38, 42, 901, DateTimeKind.Utc).AddTicks(2495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 10, 21, 3, 330, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("3d40169a-d305-476c-8c71-159e1c275d34"), new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9748), "giapp1@vmogroup.com", "Pham", "Pham Quang Giap 1", true, "Quang Giap 1", new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9748), new byte[] { 161, 169, 129, 239, 45, 5, 48, 122, 21, 171, 52, 73, 190, 42, 126, 253, 182, 108, 118, 236, 76, 130, 19, 5, 240, 218, 62, 164, 255, 79, 142, 94, 103, 214, 142, 56, 27, 197, 128, 216, 199, 208, 250, 174, 131, 22, 228, 40, 68, 182, 69, 124, 139, 143, 82, 78, 63, 206, 192, 105, 141, 197, 208, 237, 198, 6, 201, 189, 198, 103, 204, 245, 245, 213, 247, 177, 53, 0, 162, 62, 190, 245, 32, 235, 202, 35, 67, 68, 221, 33, 127, 147, 217, 177, 27, 237, 247, 247, 77, 9, 50, 107, 97, 142, 236, 76, 39, 155, 147, 39, 37, 79, 243, 250, 80, 48, 126, 61, 136, 156, 225, 207, 131, 43, 245, 230, 17, 194 }, new byte[] { 242, 252, 255, 170, 167, 245, 99, 202, 91, 29, 181, 33, 118, 136, 225, 153, 235, 67, 19, 244, 44, 75, 109, 162, 12, 192, 16, 241, 19, 94, 253, 223, 252, 50, 24, 197, 46, 107, 174, 130, 119, 251, 227, 220, 94, 11, 240, 62, 213, 65, 55, 174, 201, 120, 48, 83, 27, 105, 184, 214, 110, 145, 36, 220 }, "giappq1" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "Id", "Created", "Email", "FirstName", "FullName", "IsActive", "LastName", "Modified", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[] { new Guid("868e4f5e-bdf5-4b3b-9209-df11cc7e53ee"), new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9743), "giapp@vmogroup.com", "Pham", "Pham Quang Giap", true, "Quang Giap", new DateTime(2024, 1, 15, 9, 38, 42, 902, DateTimeKind.Utc).AddTicks(9745), new byte[] { 161, 169, 129, 239, 45, 5, 48, 122, 21, 171, 52, 73, 190, 42, 126, 253, 182, 108, 118, 236, 76, 130, 19, 5, 240, 218, 62, 164, 255, 79, 142, 94, 103, 214, 142, 56, 27, 197, 128, 216, 199, 208, 250, 174, 131, 22, 228, 40, 68, 182, 69, 124, 139, 143, 82, 78, 63, 206, 192, 105, 141, 197, 208, 237, 198, 6, 201, 189, 198, 103, 204, 245, 245, 213, 247, 177, 53, 0, 162, 62, 190, 245, 32, 235, 202, 35, 67, 68, 221, 33, 127, 147, 217, 177, 27, 237, 247, 247, 77, 9, 50, 107, 97, 142, 236, 76, 39, 155, 147, 39, 37, 79, 243, 250, 80, 48, 126, 61, 136, 156, 225, 207, 131, 43, 245, 230, 17, 194 }, new byte[] { 242, 252, 255, 170, 167, 245, 99, 202, 91, 29, 181, 33, 118, 136, 225, 153, 235, 67, 19, 244, 44, 75, 109, 162, 12, 192, 16, 241, 19, 94, 253, 223, 252, 50, 24, 197, 46, 107, 174, 130, 119, 251, 227, 220, 94, 11, 240, 62, 213, 65, 55, 174, 201, 120, 48, 83, 27, 105, 184, 214, 110, 145, 36, 220 }, "giappq" });
        }
    }
}

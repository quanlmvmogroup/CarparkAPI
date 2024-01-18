using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8669),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8520),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3154),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3040),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4388),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4274),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3206),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3093),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3813),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3695),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2626),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2512),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1995),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1865),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5809),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5661),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.InsertData(
                table: "car_park_type",
                columns: new[] { "id", "car_park_type_name", "deleted_at" },
                values: new object[] { (short)0, "BASEMENT CAR PARK", null });

            migrationBuilder.InsertData(
                table: "car_park_type",
                columns: new[] { "id", "car_park_type_name", "deleted_at" },
                values: new object[] { (short)1, "MULTI-STOREY CAR PARK", null });

            migrationBuilder.InsertData(
                table: "car_park_type",
                columns: new[] { "id", "car_park_type_name", "deleted_at" },
                values: new object[] { (short)2, "SURFACE CAR PARK", null });

            migrationBuilder.InsertData(
                table: "free_parking_type",
                columns: new[] { "id", "deleted_at", "free_parking_type_name" },
                values: new object[] { (short)0, null, "NO" });

            migrationBuilder.InsertData(
                table: "free_parking_type",
                columns: new[] { "id", "deleted_at", "free_parking_type_name" },
                values: new object[] { (short)1, null, "SUN & PH FR 7AM-10.30PM" });

            migrationBuilder.InsertData(
                table: "night_parking_type",
                columns: new[] { "id", "deleted_at", "night_parking_type_name" },
                values: new object[] { (short)0, null, "NO" });

            migrationBuilder.InsertData(
                table: "night_parking_type",
                columns: new[] { "id", "deleted_at", "night_parking_type_name" },
                values: new object[] { (short)1, null, "YES" });

            migrationBuilder.InsertData(
                table: "parking_system_type",
                columns: new[] { "id", "deleted_at", "type_of_parking_system_name" },
                values: new object[] { (short)0, null, "ELECTRONIC PARKING" });

            migrationBuilder.InsertData(
                table: "parking_system_type",
                columns: new[] { "id", "deleted_at", "type_of_parking_system_name" },
                values: new object[] { (short)1, null, "COUPON PARKING" });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[] { (short)0, null, "NO" });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[] { (short)1, null, "7AM-7PM" });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[] { (short)2, null, "7AM-10.30PM" });

            migrationBuilder.InsertData(
                table: "short_term_parking_type",
                columns: new[] { "id", "deleted_at", "short_term_parking_name" },
                values: new object[] { (short)3, null, "WHOLE DAY" });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "id", "created_at", "deleted_at", "email", "first_name", "full_name", "is_active", "last_name", "modified_at", "password_hash", "password_salt", "user_name" },
                values: new object[] { new Guid("98a5a91d-284b-49cb-8535-e5c3c32b7267"), new DateTime(2024, 1, 18, 9, 9, 7, 273, DateTimeKind.Utc).AddTicks(6792), null, "admin@vmogroup.com", "Admin", "Admin Admin", true, "Admin", new DateTime(2024, 1, 18, 9, 9, 7, 273, DateTimeKind.Utc).AddTicks(6795), new byte[] { 246, 79, 245, 183, 38, 31, 195, 189, 119, 33, 27, 230, 238, 226, 124, 129, 94, 193, 27, 230, 206, 124, 221, 237, 223, 20, 182, 241, 120, 41, 46, 76, 230, 222, 65, 134, 182, 51, 44, 22, 157, 38, 90, 212, 133, 241, 49, 201, 204, 53, 174, 123, 138, 249, 91, 70, 151, 119, 43, 194, 78, 185, 173, 207 }, new byte[] { 131, 147, 140, 198, 136, 198, 235, 128, 37, 14, 221, 138, 183, 57, 235, 253, 169, 207, 120, 91, 112, 233, 81, 36, 143, 244, 167, 206, 227, 3, 213, 152, 255, 242, 27, 80, 217, 22, 144, 80, 145, 1, 77, 173, 110, 142, 223, 108, 26, 253, 125, 66, 160, 201, 181, 75, 11, 114, 255, 31, 54, 191, 13, 113, 102, 175, 253, 95, 228, 178, 202, 138, 128, 47, 26, 70, 59, 3, 228, 148, 109, 50, 39, 10, 254, 34, 104, 106, 3, 173, 114, 37, 9, 208, 207, 145, 121, 98, 98, 186, 95, 199, 76, 62, 29, 50, 6, 183, 187, 150, 46, 20, 29, 197, 167, 232, 198, 12, 66, 108, 216, 119, 57, 153, 135, 56, 56, 140 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "car_park_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "free_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "night_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "parking_system_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)0);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)1);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)2);

            migrationBuilder.DeleteData(
                table: "short_term_parking_type",
                keyColumn: "id",
                keyValue: (short)3);

            migrationBuilder.DeleteData(
                table: "user",
                keyColumn: "id",
                keyValue: new Guid("98a5a91d-284b-49cb-8535-e5c3c32b7267"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user_favorite",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3967),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user_favorite",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 652, DateTimeKind.Utc).AddTicks(3579),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "user",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(7011),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "user",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "short_term_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9288),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "short_term_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(9171),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "parking_system_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8004),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "parking_system_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7892),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "night_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8665),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "night_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(8556),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "free_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7384),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "free_parking_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(7271),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6833),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park_type",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 651, DateTimeKind.Utc).AddTicks(6693),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified_at",
                table: "car_park",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "car_park",
                type: "TEXT",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 18, 9, 7, 58, 649, DateTimeKind.Utc).AddTicks(9537),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5661));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class change_table_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.AlterColumn<short>(
                name: "NightParking",
                table: "car_park_detail",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<short>(
                name: "FreeParking",
                table: "car_park_detail",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<short>(
                name: "CarParkBasement",
                table: "car_park_detail",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 15, 6, 49, 50, 971, DateTimeKind.Utc).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 15, 8, 48, 42, 108, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.AlterColumn<bool>(
                name: "NightParking",
                table: "car_park_detail",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);

            migrationBuilder.AlterColumn<bool>(
                name: "FreeParking",
                table: "car_park_detail",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);

            migrationBuilder.AlterColumn<bool>(
                name: "CarParkBasement",
                table: "car_park_detail",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldDefaultValue: (short)0);
        }
    }
}

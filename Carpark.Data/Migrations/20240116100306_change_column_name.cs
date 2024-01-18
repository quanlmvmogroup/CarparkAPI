using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpark.Data.Migrations
{
    public partial class change_column_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_user_favorite_car_park_CarParkNo",
                table: "user_favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_user_favorite_user_UserId",
                table: "user_favorite");

            migrationBuilder.RenameColumn(
                name: "CarParkNo",
                table: "user_favorite",
                newName: "car_park_no");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "user_favorite",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_favorite_UserId",
                table: "user_favorite",
                newName: "IX_user_favorite_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_favorite_CarParkNo",
                table: "user_favorite",
                newName: "IX_user_favorite_car_park_no");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "user",
                newName: "modified");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "user",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "user",
                newName: "created");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "user",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "user",
                newName: "password_salt");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "user",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "user",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "user",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "user",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "user",
                newName: "first_name");

            migrationBuilder.RenameIndex(
                name: "IX_user_UserName",
                table: "user",
                newName: "IX_user_user_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "short_term_parking_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ShortTermParkingName",
                table: "short_term_parking_type",
                newName: "short_term_parking_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "parking_system_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ParkingTypeSystemName",
                table: "parking_system_type",
                newName: "type_of_parking_system_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "night_parking_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NightParkingTypeName",
                table: "night_parking_type",
                newName: "night_parking_type_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "free_parking_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FreeParkingTypeName",
                table: "free_parking_type",
                newName: "free_parking_type_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "car_park_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CarParkTypeName",
                table: "car_park_type",
                newName: "car_park_type_name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "car_park",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "YCoord",
                table: "car_park",
                newName: "y_coord");

            migrationBuilder.RenameColumn(
                name: "XCoord",
                table: "car_park",
                newName: "x_coord");

            migrationBuilder.RenameColumn(
                name: "ShortTermParkingType",
                table: "car_park",
                newName: "short_term_parking");

            migrationBuilder.RenameColumn(
                name: "ParkingTypeSystem",
                table: "car_park",
                newName: "type_of_parking_system");

            migrationBuilder.RenameColumn(
                name: "NightParkingType",
                table: "car_park",
                newName: "night_parking");

            migrationBuilder.RenameColumn(
                name: "GantryHeight",
                table: "car_park",
                newName: "ganny_height");

            migrationBuilder.RenameColumn(
                name: "FreeParkingType",
                table: "car_park",
                newName: "free_parking");

            migrationBuilder.RenameColumn(
                name: "CarParkType",
                table: "car_park",
                newName: "car_park_type");

            migrationBuilder.RenameColumn(
                name: "CarParkDeck",
                table: "car_park",
                newName: "car_park_decks");

            migrationBuilder.RenameColumn(
                name: "CarParkBasement",
                table: "car_park",
                newName: "car_park_basements");

            migrationBuilder.RenameColumn(
                name: "CarParkNo",
                table: "car_park",
                newName: "car_park_no");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_ShortTermParkingType",
                table: "car_park",
                newName: "IX_car_park_short_term_parking");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_ParkingTypeSystem",
                table: "car_park",
                newName: "IX_car_park_type_of_parking_system");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_NightParkingType",
                table: "car_park",
                newName: "IX_car_park_night_parking");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_FreeParkingType",
                table: "car_park",
                newName: "IX_car_park_free_parking");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_CarParkType",
                table: "car_park",
                newName: "IX_car_park_car_park_type");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_CarParkNo",
                table: "car_park",
                newName: "IX_car_park_car_park_no");

            migrationBuilder.AlterColumn<DateTime>(
                name: "modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "user",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_car_park_type_car_park_type",
                table: "car_park",
                column: "car_park_type",
                principalTable: "car_park_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_free_parking_type_free_parking",
                table: "car_park",
                column: "free_parking",
                principalTable: "free_parking_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_night_parking_type_night_parking",
                table: "car_park",
                column: "night_parking",
                principalTable: "night_parking_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_parking_system_type_type_of_parking_system",
                table: "car_park",
                column: "type_of_parking_system",
                principalTable: "parking_system_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_car_park_short_term_parking_type_short_term_parking",
                table: "car_park",
                column: "short_term_parking",
                principalTable: "short_term_parking_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_favorite_car_park_car_park_no",
                table: "user_favorite",
                column: "car_park_no",
                principalTable: "car_park",
                principalColumn: "car_park_no",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_favorite_user_user_id",
                table: "user_favorite",
                column: "user_id",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_park_car_park_type_car_park_type",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_free_parking_type_free_parking",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_night_parking_type_night_parking",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_parking_system_type_type_of_parking_system",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_car_park_short_term_parking_type_short_term_parking",
                table: "car_park");

            migrationBuilder.DropForeignKey(
                name: "FK_user_favorite_car_park_car_park_no",
                table: "user_favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_user_favorite_user_user_id",
                table: "user_favorite");

            migrationBuilder.RenameColumn(
                name: "car_park_no",
                table: "user_favorite",
                newName: "CarParkNo");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "user_favorite",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_user_favorite_user_id",
                table: "user_favorite",
                newName: "IX_user_favorite_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_user_favorite_car_park_no",
                table: "user_favorite",
                newName: "IX_user_favorite_CarParkNo");

            migrationBuilder.RenameColumn(
                name: "modified",
                table: "user",
                newName: "Modified");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "user",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "created",
                table: "user",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "user",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password_salt",
                table: "user",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "user",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "user",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "user",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "user",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "user",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_user_user_name",
                table: "user",
                newName: "IX_user_UserName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "short_term_parking_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "short_term_parking_name",
                table: "short_term_parking_type",
                newName: "ShortTermParkingName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "parking_system_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "type_of_parking_system_name",
                table: "parking_system_type",
                newName: "ParkingTypeSystemName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "night_parking_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "night_parking_type_name",
                table: "night_parking_type",
                newName: "NightParkingTypeName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "free_parking_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "free_parking_type_name",
                table: "free_parking_type",
                newName: "FreeParkingTypeName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "car_park_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "car_park_type_name",
                table: "car_park_type",
                newName: "CarParkTypeName");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "car_park",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "y_coord",
                table: "car_park",
                newName: "YCoord");

            migrationBuilder.RenameColumn(
                name: "x_coord",
                table: "car_park",
                newName: "XCoord");

            migrationBuilder.RenameColumn(
                name: "type_of_parking_system",
                table: "car_park",
                newName: "ParkingTypeSystem");

            migrationBuilder.RenameColumn(
                name: "short_term_parking",
                table: "car_park",
                newName: "ShortTermParkingType");

            migrationBuilder.RenameColumn(
                name: "night_parking",
                table: "car_park",
                newName: "NightParkingType");

            migrationBuilder.RenameColumn(
                name: "ganny_height",
                table: "car_park",
                newName: "GantryHeight");

            migrationBuilder.RenameColumn(
                name: "free_parking",
                table: "car_park",
                newName: "FreeParkingType");

            migrationBuilder.RenameColumn(
                name: "car_park_type",
                table: "car_park",
                newName: "CarParkType");

            migrationBuilder.RenameColumn(
                name: "car_park_decks",
                table: "car_park",
                newName: "CarParkDeck");

            migrationBuilder.RenameColumn(
                name: "car_park_basements",
                table: "car_park",
                newName: "CarParkBasement");

            migrationBuilder.RenameColumn(
                name: "car_park_no",
                table: "car_park",
                newName: "CarParkNo");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_type_of_parking_system",
                table: "car_park",
                newName: "IX_car_park_ParkingTypeSystem");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_short_term_parking",
                table: "car_park",
                newName: "IX_car_park_ShortTermParkingType");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_night_parking",
                table: "car_park",
                newName: "IX_car_park_NightParkingType");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_free_parking",
                table: "car_park",
                newName: "IX_car_park_FreeParkingType");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_car_park_type",
                table: "car_park",
                newName: "IX_car_park_CarParkType");

            migrationBuilder.RenameIndex(
                name: "IX_car_park_car_park_no",
                table: "car_park",
                newName: "IX_car_park_CarParkNo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Modified",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "user",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 1, 16, 3, 36, 49, 729, DateTimeKind.Utc).AddTicks(5559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 1, 16, 10, 3, 6, 373, DateTimeKind.Utc).AddTicks(9294));

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

            migrationBuilder.AddForeignKey(
                name: "FK_user_favorite_car_park_CarParkNo",
                table: "user_favorite",
                column: "CarParkNo",
                principalTable: "car_park",
                principalColumn: "CarParkNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_favorite_user_UserId",
                table: "user_favorite",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

﻿// <auto-generated />
using System;
using Carpark.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Carpark.Infrastructure.Migrations
{
    [DbContext(typeof(CarparkDbContext))]
    [Migration("20240118090907_seed_data")]
    partial class seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.26");

            modelBuilder.Entity("Carpark.Core.Entities.CarPark", b =>
                {
                    b.Property<string>("CarParkNo")
                        .HasColumnType("TEXT")
                        .HasColumnName("car_park_no");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT")
                        .HasColumnName("address");

                    b.Property<short>("CarParkBasement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue((short)0)
                        .HasColumnName("car_park_basement");

                    b.Property<short>("CarParkDeck")
                        .HasColumnType("INTEGER")
                        .HasColumnName("car_park_decks");

                    b.Property<short>("CarParkType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("car_park_type");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5661))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<short>("FreeParkingType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("free_parking");

                    b.Property<decimal>("GantryHeight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m)
                        .HasColumnName("gantry_height");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(5809))
                        .HasColumnName("modified_at");

                    b.Property<short>("NightParkingType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("night_parking");

                    b.Property<short>("ParkingTypeSystem")
                        .HasColumnType("INTEGER")
                        .HasColumnName("type_of_parking_system");

                    b.Property<short>("ShortTermParkingType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("short_term_parking");

                    b.Property<decimal>("XCoord")
                        .HasColumnType("TEXT")
                        .HasColumnName("x_coord");

                    b.Property<decimal>("YCoord")
                        .HasColumnType("TEXT")
                        .HasColumnName("y_coord");

                    b.HasKey("CarParkNo");

                    b.HasIndex("CarParkNo")
                        .IsUnique();

                    b.HasIndex("CarParkType");

                    b.HasIndex("FreeParkingType");

                    b.HasIndex("NightParkingType");

                    b.HasIndex("ParkingTypeSystem");

                    b.HasIndex("ShortTermParkingType");

                    b.ToTable("car_park", (string)null);
                });

            modelBuilder.Entity("Carpark.Core.Entities.CarParkType", b =>
                {
                    b.Property<short?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("CarParkTypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("car_park_type_name");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1865))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(1995))
                        .HasColumnName("modified_at");

                    b.HasKey("Id");

                    b.ToTable("car_park_type", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)0,
                            CarParkTypeName = "BASEMENT CAR PARK"
                        },
                        new
                        {
                            Id = (short)1,
                            CarParkTypeName = "MULTI-STOREY CAR PARK"
                        },
                        new
                        {
                            Id = (short)2,
                            CarParkTypeName = "SURFACE CAR PARK"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.FreeParkingType", b =>
                {
                    b.Property<short?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2512))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("FreeParkingTypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("free_parking_type_name");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(2626))
                        .HasColumnName("modified_at");

                    b.HasKey("Id");

                    b.ToTable("free_parking_type", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)0,
                            FreeParkingTypeName = "NO"
                        },
                        new
                        {
                            Id = (short)1,
                            FreeParkingTypeName = "SUN & PH FR 7AM-10.30PM"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.NightParkingType", b =>
                {
                    b.Property<short?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3695))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3813))
                        .HasColumnName("modified_at");

                    b.Property<string>("NightParkingTypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("night_parking_type_name");

                    b.HasKey("Id");

                    b.ToTable("night_parking_type", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)0,
                            NightParkingTypeName = "NO"
                        },
                        new
                        {
                            Id = (short)1,
                            NightParkingTypeName = "YES"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.ParkingTypeSystem", b =>
                {
                    b.Property<short?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3093))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(3206))
                        .HasColumnName("modified_at");

                    b.Property<string>("ParkingTypeSystemName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("type_of_parking_system_name");

                    b.HasKey("Id");

                    b.ToTable("parking_system_type", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)0,
                            ParkingTypeSystemName = "ELECTRONIC PARKING"
                        },
                        new
                        {
                            Id = (short)1,
                            ParkingTypeSystemName = "COUPON PARKING"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.ShortTermParkingType", b =>
                {
                    b.Property<short?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4274))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(4388))
                        .HasColumnName("modified_at");

                    b.Property<string>("ShortTermParkingName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("short_term_parking_name");

                    b.HasKey("Id");

                    b.ToTable("short_term_parking_type", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (short)0,
                            ShortTermParkingName = "NO"
                        },
                        new
                        {
                            Id = (short)1,
                            ShortTermParkingName = "7AM-7PM"
                        },
                        new
                        {
                            Id = (short)2,
                            ShortTermParkingName = "7AM-10.30PM"
                        },
                        new
                        {
                            Id = (short)3,
                            ShortTermParkingName = "WHOLE DAY"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.UserFavorite", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_id");

                    b.Property<string>("CarParkNo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("car_park_no");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8520))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 272, DateTimeKind.Utc).AddTicks(8669))
                        .HasColumnName("modified_at");

                    b.HasKey("UserId");

                    b.HasIndex("CarParkNo")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("user_favorite", (string)null);
                });

            modelBuilder.Entity("Carpark.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3040))
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("first_name");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("full_name");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true)
                        .HasColumnName("is_active");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("last_name");

                    b.Property<DateTime?>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2024, 1, 18, 9, 9, 7, 270, DateTimeKind.Utc).AddTicks(3154))
                        .HasColumnName("modified_at");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB")
                        .HasColumnName("password_hash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB")
                        .HasColumnName("password_salt");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("user", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("98a5a91d-284b-49cb-8535-e5c3c32b7267"),
                            CreatedAt = new DateTime(2024, 1, 18, 9, 9, 7, 273, DateTimeKind.Utc).AddTicks(6792),
                            Email = "admin@vmogroup.com",
                            FirstName = "Admin",
                            FullName = "Admin Admin",
                            IsActive = true,
                            LastName = "Admin",
                            ModifiedAt = new DateTime(2024, 1, 18, 9, 9, 7, 273, DateTimeKind.Utc).AddTicks(6795),
                            PasswordHash = new byte[] { 246, 79, 245, 183, 38, 31, 195, 189, 119, 33, 27, 230, 238, 226, 124, 129, 94, 193, 27, 230, 206, 124, 221, 237, 223, 20, 182, 241, 120, 41, 46, 76, 230, 222, 65, 134, 182, 51, 44, 22, 157, 38, 90, 212, 133, 241, 49, 201, 204, 53, 174, 123, 138, 249, 91, 70, 151, 119, 43, 194, 78, 185, 173, 207 },
                            PasswordSalt = new byte[] { 131, 147, 140, 198, 136, 198, 235, 128, 37, 14, 221, 138, 183, 57, 235, 253, 169, 207, 120, 91, 112, 233, 81, 36, 143, 244, 167, 206, 227, 3, 213, 152, 255, 242, 27, 80, 217, 22, 144, 80, 145, 1, 77, 173, 110, 142, 223, 108, 26, 253, 125, 66, 160, 201, 181, 75, 11, 114, 255, 31, 54, 191, 13, 113, 102, 175, 253, 95, 228, 178, 202, 138, 128, 47, 26, 70, 59, 3, 228, 148, 109, 50, 39, 10, 254, 34, 104, 106, 3, 173, 114, 37, 9, 208, 207, 145, 121, 98, 98, 186, 95, 199, 76, 62, 29, 50, 6, 183, 187, 150, 46, 20, 29, 197, 167, 232, 198, 12, 66, 108, 216, 119, 57, 153, 135, 56, 56, 140 },
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Carpark.Core.Entities.CarPark", b =>
                {
                    b.HasOne("Carpark.Core.Entities.CarParkType", "CarParkTypeNavigation")
                        .WithMany("CarParkNavigation")
                        .HasForeignKey("CarParkType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpark.Core.Entities.FreeParkingType", "FreeParkingNavigation")
                        .WithMany("CarParkNavigation")
                        .HasForeignKey("FreeParkingType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpark.Core.Entities.NightParkingType", "NightParkingNavigation")
                        .WithMany("CarParkNavigation")
                        .HasForeignKey("NightParkingType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpark.Core.Entities.ParkingTypeSystem", "TypeOfParkingSystemNavigation")
                        .WithMany("CarParkNavigation")
                        .HasForeignKey("ParkingTypeSystem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpark.Core.Entities.ShortTermParkingType", "ShortTermParkingNavigation")
                        .WithMany("CarParkNavigation")
                        .HasForeignKey("ShortTermParkingType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarParkTypeNavigation");

                    b.Navigation("FreeParkingNavigation");

                    b.Navigation("NightParkingNavigation");

                    b.Navigation("ShortTermParkingNavigation");

                    b.Navigation("TypeOfParkingSystemNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.UserFavorite", b =>
                {
                    b.HasOne("Carpark.Core.Entities.CarPark", "CarParkNavigation")
                        .WithOne("UserFavoriteNavigation")
                        .HasForeignKey("Carpark.Core.Entities.UserFavorite", "CarParkNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpark.Data.Entities.User", "UserNavigation")
                        .WithOne("UserFavoriteNavigation")
                        .HasForeignKey("Carpark.Core.Entities.UserFavorite", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarParkNavigation");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.CarPark", b =>
                {
                    b.Navigation("UserFavoriteNavigation")
                        .IsRequired();
                });

            modelBuilder.Entity("Carpark.Core.Entities.CarParkType", b =>
                {
                    b.Navigation("CarParkNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.FreeParkingType", b =>
                {
                    b.Navigation("CarParkNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.NightParkingType", b =>
                {
                    b.Navigation("CarParkNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.ParkingTypeSystem", b =>
                {
                    b.Navigation("CarParkNavigation");
                });

            modelBuilder.Entity("Carpark.Core.Entities.ShortTermParkingType", b =>
                {
                    b.Navigation("CarParkNavigation");
                });

            modelBuilder.Entity("Carpark.Data.Entities.User", b =>
                {
                    b.Navigation("UserFavoriteNavigation")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

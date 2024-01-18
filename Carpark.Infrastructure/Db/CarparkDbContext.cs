using Carpark.Core.Entities;
using Carpark.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpark.Infrastructure.Db
{
    public class CarparkDbContext : DbContext
    {
        public CarparkDbContext(DbContextOptions<CarparkDbContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CarPark> Carparks { get; set; }
        public virtual DbSet<UserFavorite> UserFavorites { get; set; }
        public virtual DbSet<CarParkType> CarParkTypes { get; set; }
        public virtual DbSet<FreeParkingType> FreeParkingTypes { get; set; }
        public virtual DbSet<NightParkingType> NightParkingTypes { get; set; }
        public virtual DbSet<ParkingTypeSystem> ParkingTypeSystems { get; set; }
        public virtual DbSet<ShortTermParkingType> ShortTermParkingTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.UserName).IsRequired().HasMaxLength(255).HasColumnName("user_name");
                entity.Property(e => e.PasswordHash).IsRequired().HasColumnName("password_hash");
                entity.Property(e => e.PasswordSalt).IsRequired().HasColumnName("password_salt");
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(255).HasColumnName("first_name");
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(255).HasColumnName("last_name");
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(255).HasColumnName("full_name");
                entity.Property(e => e.Email).IsRequired().HasMaxLength(255).HasColumnName("email");
                entity.Property(e => e.IsActive).IsRequired().HasDefaultValue(true).HasColumnName("is_active");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");

                entity.HasIndex(e => e.UserName).IsUnique();
            });

            modelBuilder.Entity<CarPark>(entity =>
            {
                entity.ToTable("car_park");

                entity.HasKey(e => e.CarParkNo);

                entity.Property(e => e.CarParkNo).HasColumnName("car_park_no");
                entity.Property(e => e.Address).IsRequired().HasMaxLength(500).HasColumnName("address");
                entity.Property(e => e.XCoord).HasColumnName("x_coord");
                entity.Property(e => e.YCoord).HasColumnName("y_coord");
                entity.Property(e => e.CarParkType).HasColumnName("car_park_type");
                entity.Property(e => e.ParkingTypeSystem).HasColumnName("type_of_parking_system");
                entity.Property(e => e.ShortTermParkingType).HasColumnName("short_term_parking");
                entity.Property(e => e.FreeParkingType).HasColumnName("free_parking");
                entity.Property(e => e.NightParkingType).HasColumnName("night_parking");
                entity.Property(e => e.CarParkDeck).IsRequired().HasColumnName("car_park_decks");
                entity.Property(e => e.GantryHeight).IsRequired().HasDefaultValue(0.0).HasColumnName("gantry_height");
                entity.Property(e => e.CarParkBasement).IsRequired().HasDefaultValue(0).HasColumnName("car_park_basement");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");

                entity.HasOne(c => c.CarParkTypeNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.CarParkType);

                entity.HasOne(c => c.FreeParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.FreeParkingType);

                entity.HasOne(c => c.NightParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.NightParkingType);

                entity.HasOne(c => c.TypeOfParkingSystemNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.ParkingTypeSystem);

                entity.HasOne(c => c.ShortTermParkingNavigation)
                      .WithMany(t => t.CarParkNavigation)
                      .HasForeignKey(c => c.ShortTermParkingType);

                entity.HasIndex(e => e.CarParkNo).IsUnique();
            });

            modelBuilder.Entity<CarParkType>(entity =>
            {
                entity.ToTable("car_park_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.CarParkTypeName).IsRequired().HasMaxLength(255).HasColumnName("car_park_type_name");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");
            });

            modelBuilder.Entity<FreeParkingType>(entity =>
            {
                entity.ToTable("free_parking_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.FreeParkingTypeName).IsRequired().HasMaxLength(255).HasColumnName("free_parking_type_name");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");
            });

            modelBuilder.Entity<ParkingTypeSystem>(entity =>
            {
                entity.ToTable("parking_system_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ParkingTypeSystemName).IsRequired().HasMaxLength(255).HasColumnName("type_of_parking_system_name");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");
            });

            modelBuilder.Entity<NightParkingType>(entity =>
            {
                entity.ToTable("night_parking_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NightParkingTypeName).IsRequired().HasMaxLength(255).HasColumnName("night_parking_type_name");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");
            });

            modelBuilder.Entity<ShortTermParkingType>(entity =>
            {
                entity.ToTable("short_term_parking_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ShortTermParkingName).IsRequired().HasMaxLength(255).HasColumnName("short_term_parking_name");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");
            });

            modelBuilder.Entity<UserFavorite>(entity =>
            {
                entity.ToTable("user_favorite");

                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.CarParkNo).HasColumnName("car_park_no");
                entity.Property(e => e.CreatedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created_at");
                entity.Property(e => e.ModifiedAt).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified_at");
                entity.Property(e => e.DeletedAt).IsRequired(false).HasColumnName("deleted_at");

                entity.HasOne(uf => uf.UserNavigation)
                      .WithOne(u => u.UserFavoriteNavigation)
                      .HasForeignKey<UserFavorite>(uf => uf.UserId);

                entity.HasOne(uf => uf.CarParkNavigation)
                      .WithOne(cp => cp.UserFavoriteNavigation)
                      .HasForeignKey<UserFavorite>(uf => uf.CarParkNo);

                entity.HasIndex(uf => uf.UserId).IsUnique();
            });

            base.OnModelCreating(modelBuilder);

            string password = "Admin@123";
            byte[] passwordSalt;
            byte[] passwordHash;

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var user1 = new User
            {
                Id = Guid.NewGuid(),
                UserName = "admin",
                FirstName = "Admin",
                LastName = "Admin",
                FullName = "Admin Admin",
                Email = "admin@vmogroup.com",
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            modelBuilder.Entity<User>().HasData(
                user1
            );

            modelBuilder.Entity<CarParkType>().HasData(
                new CarParkType
                {
                    Id = 0,
                    CarParkTypeName = "BASEMENT CAR PARK"
                },
                new CarParkType
                {
                    Id = 1,
                    CarParkTypeName = "MULTI-STOREY CAR PARK"
                },
                new CarParkType
                {
                    Id = 2,
                    CarParkTypeName = "SURFACE CAR PARK"
                }
            );

            modelBuilder.Entity<ParkingTypeSystem>().HasData(
                new ParkingTypeSystem
                {
                    Id = 0,
                    ParkingTypeSystemName = "ELECTRONIC PARKING"
                },
                new ParkingTypeSystem
                {
                    Id = 1,
                    ParkingTypeSystemName = "COUPON PARKING"
                }
            );

            modelBuilder.Entity<ShortTermParkingType>().HasData(
                new ShortTermParkingType
                {
                    Id = 0,
                    ShortTermParkingName = "NO"
                },
                new ShortTermParkingType
                {
                    Id = 1,
                    ShortTermParkingName = "7AM-7PM"
                },
                new ShortTermParkingType
                {
                    Id = 2,
                    ShortTermParkingName = "7AM-10.30PM"
                },
                new ShortTermParkingType
                {
                    Id = 3,
                    ShortTermParkingName = "WHOLE DAY"
                }
            );

            modelBuilder.Entity<FreeParkingType>().HasData(
                new FreeParkingType
                {
                    Id = 0,
                    FreeParkingTypeName = "NO"
                },
                new FreeParkingType
                {
                    Id = 1,
                    FreeParkingTypeName = "SUN & PH FR 7AM-10.30PM"
                }
            );

            modelBuilder.Entity<NightParkingType>().HasData(
                new NightParkingType
                {
                    Id = 0,

                    NightParkingTypeName = "NO"
                },
                new NightParkingType
                {
                    Id = 1,

                    NightParkingTypeName = "YES"
                }
            );
        }
    }
}

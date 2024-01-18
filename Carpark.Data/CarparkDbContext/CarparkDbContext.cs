using Carpark.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Carpark.Data.CarparkDbContext
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
                entity.Property(e => e.Created).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("created");
                entity.Property(e => e.Modified).IsRequired(false).HasDefaultValue(DateTime.UtcNow).HasColumnName("modified");

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
            });

            modelBuilder.Entity<FreeParkingType>(entity =>
            {
                entity.ToTable("free_parking_type");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.FreeParkingTypeName).IsRequired().HasMaxLength(255).HasColumnName("free_parking_type_name");
            });

            modelBuilder.Entity<ParkingTypeSystem>(entity =>
            {
                entity.ToTable("parking_system_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ParkingTypeSystemName).IsRequired().HasMaxLength(255).HasColumnName("type_of_parking_system_name");
            });

            modelBuilder.Entity<NightParkingType>(entity =>
            {
                entity.ToTable("night_parking_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NightParkingTypeName).IsRequired().HasMaxLength(255).HasColumnName("night_parking_type_name");
            });

            modelBuilder.Entity<ShortTermParkingType>(entity =>
            {
                entity.ToTable("short_term_parking_type");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ShortTermParkingName).IsRequired().HasMaxLength(255).HasColumnName("short_term_parking_name");
            });

            modelBuilder.Entity<UserFavorite>(entity => 
            {
                entity.ToTable("user_favorite");

                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.CarParkNo).HasColumnName("car_park_no");

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
                UserName = "giappq",
                FirstName = "Pham",
                LastName = "Quang Giap",
                FullName = "Pham Quang Giap",
                Email = "giapp@vmogroup.com",
                IsActive = true,
                Created = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            var user2 = new User
            {
                Id = Guid.NewGuid(),
                UserName = "giappq1",
                FirstName = "Pham",
                LastName = "Quang Giap 1",
                FullName = "Pham Quang Giap 1",
                Email = "giapp1@vmogroup.com",
                IsActive = true,
                Created = DateTime.UtcNow,
                Modified = DateTime.UtcNow,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            modelBuilder.Entity<User>().HasData(
                user1,
                user2
            );
        }
    }
}

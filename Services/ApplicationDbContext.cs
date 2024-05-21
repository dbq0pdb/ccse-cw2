using ccsecw1.Models;
using ccsecw1.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ccsecw1
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourBooking> TourBookings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define entity configurations
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.Id).HasMaxLength(128);
                b.Property(u => u.FirstName).HasMaxLength(100);
                b.Property(u => u.LastName).HasMaxLength(100);
            });

            modelBuilder.Entity<Booking>(b =>
            {
                b.HasOne(b => b.ApplicationUser).WithMany(u => u.Bookings).HasForeignKey(b => b.CustomerNumber);
            });

            modelBuilder.Entity<Hotel>(h =>
            {
                h.Property(h => h.Name).HasMaxLength(100);
                h.Property(h => h.Brand).HasMaxLength(100);
            });

            modelBuilder.Entity<Room>(r =>
            {
                r.HasOne(r => r.Hotel).WithMany(h => h.Rooms).HasForeignKey(r => r.HotelId);
            });

            modelBuilder.Entity<Tour>(t =>
            {
                t.Property(t => t.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TourBooking>(tb =>
            {
                tb.HasOne(tb => tb.Tour).WithMany().HasForeignKey(tb => tb.TourId);
            });

            // ------------- Seed data -----------------

            // adding user roles
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var manager = new IdentityRole("manager");
            manager.NormalizedName = "manager";

            var customer = new IdentityRole("customer");
            customer.NormalizedName = "customer";

            modelBuilder.Entity<IdentityRole>().HasData(admin, manager, customer);


            // adding users
            for (int i = 0; i < 10; i++)
            {
                var user = new ApplicationUser
                {
                    FirstName = ModelData.GenerateRandomName().Split(' ')[0],
                    LastName = ModelData.GenerateRandomName().Split(' ')[1],
                    Address = ModelData.GenerateRandomAddress(),
                    PassPortNumber = ModelData.GenerateRandomPassportNumber(),
                    CustomerNumber = Guid.NewGuid(),
                    CreatedAt = DateTime.Now,
                    Email = ("user" + i + "@example.com").ToLower(),
                    EmailConfirmed = ModelData.GenerateRandomBoolean(),
                    PasswordHash = Guid.NewGuid().ToString(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = ModelData.GenerateRandomPhoneNumber(),
                    PhoneNumberConfirmed = ModelData.GenerateRandomBoolean(),
                    TwoFactorEnabled = ModelData.GenerateRandomBoolean(),
                    LockoutEnd = null,
                    LockoutEnabled = ModelData.GenerateRandomBoolean(),
                    AccessFailedCount = 0
                };
                modelBuilder.Entity<ApplicationUser>().HasData(user);
            }


            // adding hotels
            var hotels = new List<Hotel>();
            for (int i = 0; i < 9; i++)
            {
                var hotel = new Hotel
                {
                    HotelId = Guid.NewGuid(),
                    Name = ModelData.GenerateRandomHotelName(),
                    Brand = ModelData.GenerateRandomBrand(),
                    Description = ModelData.GenerateRandomDescription(),
                    Rating = ModelData.GenerateRandomRating(),
                    Location = ModelData.GenerateRandomLocation(),
                    Address = ModelData.GenerateRandomAddress(),
                    SingleRoomPrice = ModelData.GenerateRandomSingleRoomPrice(),
                    DoubleRoomPrice = ModelData.GenerateRandomDoubleRoomPrice(),
                    FamilyRoomPrice = ModelData.GenerateRandomFamilyRoomPrice(),
                };
                hotels.Add(hotel);
                modelBuilder.Entity<Hotel>().HasData(hotel);
            }


            // adding tours
            for (int i = 0; i < 9; i++)
            {
                var tour = new Tour
                {
                    TourId = Guid.NewGuid(),
                    Name = ModelData.GenerateRandomTourName(),
                    Brand = ModelData.GenerateRandomBrand(),
                    Description = ModelData.GenerateRandomDescription(),
                    Rating = ModelData.GenerateRandomRating(),
                    Location = ModelData.GenerateRandomLocation(),
                    Address = ModelData.GenerateRandomAddress(),
                    DurationDays = ModelData.GenerateRandomDuration(),
                    PricePerDay = ModelData.GenerateRandomTourPricePerDay(),
                    TotalTourPrice = ModelData.GenerateTourPrice(ModelData.GenerateRandomDuration(), ModelData.GenerateRandomTourPricePerDay()),
                    TotalSpaces = ModelData.GenerateRandomTotalSpaces(),
                };
                modelBuilder.Entity<Tour>().HasData(tour);
            }


            // ... (other code remains unchanged)

            // adding rooms
            var roomtypes = ModelData.GenerateRoomTypes();
            modelBuilder.Entity<RoomType>().HasData(roomtypes);

            foreach (var hotel in hotels)
            {
                for (var x = 0; x < 20; x++)
                {
                    var singleRoom = new Room
                    {
                        RoomId = Guid.NewGuid(),
                        HotelId = hotel.HotelId,
                        RoomNumber = "S" + (x + 1),
                        RoomTypeId = roomtypes[0].RoomTypeId, 
                        RoomPrice = hotel.SingleRoomPrice
                    };
                    modelBuilder.Entity<Room>().HasData(singleRoom);

                    var doubleRoom = new Room
                    {
                        RoomId = Guid.NewGuid(),
                        HotelId = hotel.HotelId,
                        RoomNumber = "D" + (x + 1),
                        RoomTypeId = roomtypes[1].RoomTypeId, 
                        RoomPrice = hotel.DoubleRoomPrice
                    };
                    modelBuilder.Entity<Room>().HasData(doubleRoom);

                    var familyRoom = new Room
                    {
                        RoomId = Guid.NewGuid(),
                        HotelId = hotel.HotelId,
                        RoomNumber = "F" + (x + 1),
                        RoomTypeId = roomtypes[2].RoomTypeId, 
                        RoomPrice = hotel.FamilyRoomPrice
                    };
                    modelBuilder.Entity<Room>().HasData(familyRoom);
                }
            }

        }
    }
}
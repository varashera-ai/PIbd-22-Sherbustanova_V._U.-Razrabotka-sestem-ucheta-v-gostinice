using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using HotelAccounting.Models;

namespace HotelAccounting.Data
{
    public class DataContext : DbContext
    {
        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Stay> Stays { get; set; }
        public DbSet<StayService> StayServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=172.20.10.5;Port=5432;Database=HotelDB;Username=postgres;Password=123;")
                    .LogTo(Console.WriteLine, LogLevel.Information) 
                    .EnableSensitiveDataLogging(); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 1. Связь Один-ко-многим: Категория -> Номера
            modelBuilder.Entity<Room>()
                .HasOne<RoomCategory>()
                .WithMany()
                .HasForeignKey(r => r.CategoryId);

            modelBuilder.Entity<Booking>()
                .HasOne<Guest>()
                .WithMany()
                .HasForeignKey(b => b.GuestId);

            modelBuilder.Entity<StayService>()
                .HasKey(ss => ss.Id);

            modelBuilder.Entity<StayService>()
                .HasOne<Stay>()
                .WithMany(s => s.StayServices)
                .HasForeignKey(ss => ss.StayId);

            modelBuilder.Entity<StayService>()
                .HasOne<Service>()
                .WithMany()
                .HasForeignKey(ss => ss.ServiceId);
        }
    }
}
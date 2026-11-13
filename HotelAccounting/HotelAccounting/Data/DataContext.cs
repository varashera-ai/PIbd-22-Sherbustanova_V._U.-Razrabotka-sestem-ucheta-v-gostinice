using Microsoft.EntityFrameworkCore;
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
                optionsBuilder.UseNpgsql("Host=172.20.10.5;Port=5432;Database=HotelDB;Username=postgres;Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Service>()
                .Property(s => s.ServiceType)
                .HasConversion<string>();

            modelBuilder.Entity<Stay>().Ignore(s => s.GuestName);
            modelBuilder.Entity<Stay>().Ignore(s => s.RoomName);
        }
    }
}
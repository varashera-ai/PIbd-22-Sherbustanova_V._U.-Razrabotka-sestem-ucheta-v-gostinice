using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class BookingRepository : IBookingRepository
{
    private readonly DataContext _context;
    private readonly ILogger<BookingRepository> _logger;

    public BookingRepository(DataContext context, ILogger<BookingRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateBooking(Booking booking)
    {
        _logger.LogInformation("Добавление бронирования");
        try
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении бронирования");
            throw;
        }
    }

    public void DeleteBooking(int id)
    {
        _logger.LogInformation("Удаление бронирования");
        var booking = _context.Bookings.Find(id);
        if (booking != null)
        {
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Booking> ReadBookings(DateTime? dateFrom = null, DateTime? dateTo = null, int? roomId = null, int? guestId = null)
    {
        _logger.LogInformation("Получение бронирований");
        var query = _context.Bookings.AsQueryable();

        if (roomId.HasValue) query = query.Where(b => b.RoomId == roomId);
        if (guestId.HasValue) query = query.Where(b => b.GuestId == guestId);

        return query.ToList();
    }
}
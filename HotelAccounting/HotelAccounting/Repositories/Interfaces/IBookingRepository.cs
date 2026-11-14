using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IBookingRepository
{
    IEnumerable<Booking> ReadBookings(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? roomId = null, int? guestId = null);
    void CreateBooking(Booking booking);
    void DeleteBooking(int id);
}
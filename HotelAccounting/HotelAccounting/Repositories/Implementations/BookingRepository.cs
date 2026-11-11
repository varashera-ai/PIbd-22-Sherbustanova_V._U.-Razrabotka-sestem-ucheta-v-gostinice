using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class BookingRepository : IBookingRepository
{
    public void CreateBooking(Booking booking)
    {
    }

    public void DeleteBooking(int id)
    {
    }

    public IEnumerable<Booking> ReadBookings(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? roomId = null, int? guestId = null)
    {
        return [];
    }
}
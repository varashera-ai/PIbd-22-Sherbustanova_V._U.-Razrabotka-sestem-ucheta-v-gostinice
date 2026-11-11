using System;

namespace HotelAccounting.Models;

public class Booking
{
    public int Id { get; private set; }
    public int GuestId { get; private set; }
    public int RoomId { get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime CheckOutDate { get; private set; }

    public static Booking CreateOperation(int id, int guestId, int roomId, DateTime checkInDate, DateTime checkOutDate)
    {
        return new Booking
        {
            Id = id,
            GuestId = guestId,
            RoomId = roomId,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate
        };
    }
}
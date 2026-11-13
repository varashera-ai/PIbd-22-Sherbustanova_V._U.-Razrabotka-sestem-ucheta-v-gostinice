using System;

namespace HotelAccounting.Models;

public class Booking
{
    public int Id { get; set; }
    public int GuestId { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }

    public Booking() { }

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
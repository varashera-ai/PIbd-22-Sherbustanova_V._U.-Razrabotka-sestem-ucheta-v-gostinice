using System;
using System.Collections.Generic;

namespace HotelAccounting.Models;

public class Stay
{
    public int Id { get; set; }
    public int GuestId { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime? CheckOutDate { get; set; }
    public decimal TotalPaid { get; set; }

    public ICollection<StayService> StayServices { get; set; } = new List<StayService>();

    public string GuestName { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;

    public Stay() { }

    public static Stay CreateOperation(int id, int guestId, int roomId, IEnumerable<StayService> stayServices)
    {
        return new Stay
        {
            Id = id,
            GuestId = guestId,
            RoomId = roomId,
            CheckInDate = DateTime.Now,
            CheckOutDate = null,
            TotalPaid = 0,
            StayServices = stayServices != null ? new List<StayService>(stayServices) : new List<StayService>()
        };
    }
}
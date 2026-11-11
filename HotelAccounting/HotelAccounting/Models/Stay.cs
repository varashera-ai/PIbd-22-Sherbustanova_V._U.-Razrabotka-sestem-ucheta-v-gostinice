using System;
using System.Collections.Generic;

namespace HotelAccounting.Models;

public class Stay
{
    public int Id { get; private set; }
    public int GuestId { get; private set; }
    public int RoomId { get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime? CheckOutDate { get; private set; }
    public decimal TotalPaid { get; private set; }
    public IEnumerable<StayService> StayServices { get; private set; } = new List<StayService>();
    public string GuestName { get; private set; } = string.Empty;
    public string RoomName { get; private set; } = string.Empty;
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
            StayServices = stayServices ?? new List<StayService>()
        };
    }
}
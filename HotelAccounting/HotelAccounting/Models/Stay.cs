using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAccounting.Models;

public class Stay
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Guest")]
    [Column("guestid")]
    public int GuestId { get; set; }

    [Required]
    [ForeignKey("Room")]
    [Column("roomid")]
    public int RoomId { get; set; }

    [Required]
    [Column("checkindate")]
    public DateTime CheckInDate { get; set; }

    [Column("checkoutdate")]
    public DateTime? CheckOutDate { get; set; }

    [Column("totalpaid")]
    public decimal TotalPaid { get; set; }

    public ICollection<StayService> StayServices { get; set; } = new List<StayService>();

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
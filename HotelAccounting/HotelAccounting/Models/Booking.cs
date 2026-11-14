using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAccounting.Models;

public class Booking
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

    [Required]
    [Column("checkoutdate")]
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
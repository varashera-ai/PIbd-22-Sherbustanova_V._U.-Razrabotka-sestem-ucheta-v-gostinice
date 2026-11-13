using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Room
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column("roomnumber")]
    public int RoomNumber { get; set; }

    [Required]
    [Column("floor")]
    public int Floor { get; set; }

    [Required]
    [Column("status")]
    public RoomStatus Status { get; set; }

    [Required]
    [ForeignKey("RoomCategory")] 
    [Column("categoryid")]
    public int CategoryId { get; set; }

    public Room() { }

    public static Room CreateEntity(int id, int roomNumber, int floor, RoomStatus status, int categoryId)
    {
        return new Room
        {
            Id = id,
            RoomNumber = roomNumber,
            Floor = floor,
            Status = status,
            CategoryId = categoryId
        };
    }
}
using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Room
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public int Floor { get; set; }
    public RoomStatus Status { get; set; }
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
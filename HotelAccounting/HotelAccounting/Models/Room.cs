using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Room
{
    public int Id { get; private set; }
    public int RoomNumber { get; private set; }
    public int Floor { get; private set; }
    public RoomStatus Status { get; private set; }
    public int CategoryId { get; private set; }

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
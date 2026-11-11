using HotelAccounting.Enums;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class RoomRepository : IRoomRepository
{
    public void CreateRoom(Room room)
    {
    }

    public void DeleteRoom(int id)
    {
    }

    public Room ReadRoomById(int id)
    {
        return Room.CreateEntity(0, 0, 0, RoomStatus.None, 0);
    }

    public IEnumerable<Room> ReadRooms()
    {
        return [];
    }

    public void UpdateRoom(Room room)
    {
    }
}
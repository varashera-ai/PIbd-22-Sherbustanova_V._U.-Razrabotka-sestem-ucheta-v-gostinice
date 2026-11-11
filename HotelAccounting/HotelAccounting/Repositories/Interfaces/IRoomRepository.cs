using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IRoomRepository
{
    IEnumerable<Room> ReadRooms();
    Room ReadRoomById(int id);
    void CreateRoom(Room room);
    void UpdateRoom(Room room);
    void DeleteRoom(int id);
}
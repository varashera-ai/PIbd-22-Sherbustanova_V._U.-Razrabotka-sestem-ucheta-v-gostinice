using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IRoomCategoryRepository
{
    IEnumerable<RoomCategory> ReadRoomCategories();
    RoomCategory ReadRoomCategoryById(int id);
    void CreateRoomCategory(RoomCategory category);
    void UpdateRoomCategory(RoomCategory category);
    void DeleteRoomCategory(int id);
}
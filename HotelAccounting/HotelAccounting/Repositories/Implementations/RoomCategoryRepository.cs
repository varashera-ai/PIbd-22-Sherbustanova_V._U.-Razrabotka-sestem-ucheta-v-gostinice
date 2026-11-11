using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class RoomCategoryRepository : IRoomCategoryRepository
{
    public void CreateRoomCategory(RoomCategory category)
    {
    }

    public void DeleteRoomCategory(int id)
    {
    }

    public RoomCategory ReadRoomCategoryById(int id)
    {
        return RoomCategory.CreateEntity(0, string.Empty, 0, 0);
    }

    public IEnumerable<RoomCategory> ReadRoomCategories()
    {
        return [];
    }

    public void UpdateRoomCategory(RoomCategory category)
    {
    }
}
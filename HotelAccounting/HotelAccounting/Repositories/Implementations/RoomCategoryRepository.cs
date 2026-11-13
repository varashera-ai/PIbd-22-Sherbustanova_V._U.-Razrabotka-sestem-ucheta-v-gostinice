using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class RoomCategoryRepository : IRoomCategoryRepository
{
    private readonly DataContext _context;
    private readonly ILogger<RoomCategoryRepository> _logger;

    public RoomCategoryRepository(DataContext context, ILogger<RoomCategoryRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateRoomCategory(RoomCategory category)
    {
        _logger.LogInformation("Добавление объекта");
        _context.RoomCategories.Add(category);
        _context.SaveChanges();
    }

    public void UpdateRoomCategory(RoomCategory category)
    {
        _logger.LogInformation("Редактирование объекта");
        try
        {
            // Отвязываем старый объект из памяти
            var existing = _context.RoomCategories.Find(category.Id);
            if (existing != null)
            {
                _context.Entry(existing).State = EntityState.Detached;
            }

            _context.RoomCategories.Update(category);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }

    public void DeleteRoomCategory(int id)
    {
        _logger.LogInformation("Удаление объекта");
        var category = _context.RoomCategories.Find(id);
        if (category != null)
        {
            _context.RoomCategories.Remove(category);
            _context.SaveChanges();
        }
    }

    public RoomCategory ReadRoomCategoryById(int id) => _context.RoomCategories.Find(id);

    public IEnumerable<RoomCategory> ReadRoomCategories() => _context.RoomCategories.ToList();
}
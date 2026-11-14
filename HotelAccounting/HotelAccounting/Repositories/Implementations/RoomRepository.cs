using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class RoomRepository : IRoomRepository
{
    private readonly DataContext _context;
    private readonly ILogger<RoomRepository> _logger;

    public RoomRepository(DataContext context, ILogger<RoomRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateRoom(Room room)
    {
        _logger.LogInformation("Добавление номера");
        _context.Rooms.Add(room);
        _context.SaveChanges();
    }

    public void UpdateRoom(Room room)
    {
        _logger.LogInformation("Редактирование номера");
        try
        {
            var existing = _context.Rooms.Find(room.Id);
            if (existing != null)
            {
                _context.Entry(existing).State = EntityState.Detached;
            }
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании номера");
            throw;
        }
    }

    public void DeleteRoom(int id)
    {
        _logger.LogInformation("Удаление номера");
        var room = _context.Rooms.Find(id);
        if (room != null)
        {
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }

    public Room ReadRoomById(int id) => _context.Rooms.Find(id);

    public IEnumerable<Room> ReadRooms() => _context.Rooms.ToList();
}
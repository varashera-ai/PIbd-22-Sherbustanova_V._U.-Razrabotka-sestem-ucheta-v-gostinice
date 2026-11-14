using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class GuestRepository : IGuestRepository
{
    private readonly DataContext _context;
    private readonly ILogger<GuestRepository> _logger;

    public GuestRepository(DataContext context, ILogger<GuestRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateGuest(Guest guest)
    {
        _logger.LogInformation("Добавление гостя");
        _context.Guests.Add(guest);
        _context.SaveChanges();
    }

    public void UpdateGuest(Guest guest)
    {
        _logger.LogInformation("Редактирование гостя");
        try
        {
            var existing = _context.Guests.Find(guest.Id);
            if (existing != null)
            {
                _context.Entry(existing).State = EntityState.Detached;
            }

            _context.Guests.Update(guest);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании гостя");
            throw;
        }
    }

    public void DeleteGuest(int id)
    {
        _logger.LogInformation("Удаление гостя");
        var guest = _context.Guests.Find(id);
        if (guest != null)
        {
            _context.Guests.Remove(guest);
            _context.SaveChanges();
        }
    }

    public Guest ReadGuestById(int id) => _context.Guests.Find(id);

    public IEnumerable<Guest> ReadGuests() => _context.Guests.ToList();
}
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class StayRepository : IStayRepository
{
    private readonly DataContext _context;
    private readonly ILogger<StayRepository> _logger;

    public StayRepository(DataContext context, ILogger<StayRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateStay(Stay stay)
    {
        _logger.LogInformation("Добавление проживания (с транзакцией)");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(stay));

        using var transaction = _context.Database.BeginTransaction();
        try
        {
            _context.Stays.Add(stay);
            _context.SaveChanges();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            _logger.LogError(ex, "Ошибка при добавлении проживания (транзакция отменена)");
            throw;
        }
    }

    public void DeleteStay(int id)
    {
        _logger.LogInformation("Удаление проживания");
        var stay = _context.Stays.Find(id);
        if (stay != null)
        {
            _context.Stays.Remove(stay);
            _context.SaveChanges();
        }
    }

    public IEnumerable<Stay> ReadStays(DateTime? dateFrom = null, DateTime? dateTo = null, int? roomId = null, int? guestId = null)
    {
        _logger.LogInformation("Получение проживаний");
        var query = _context.Stays.AsQueryable();

        if (roomId.HasValue) query = query.Where(s => s.RoomId == roomId);
        if (guestId.HasValue) query = query.Where(s => s.GuestId == guestId);

        return query.ToList();
    }
}
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HotelAccounting.Data;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelAccounting.Repositories.Implementations;

internal class ServiceRepository : IServiceRepository
{
    private readonly DataContext _context;
    private readonly ILogger<ServiceRepository> _logger;

    public ServiceRepository(DataContext context, ILogger<ServiceRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void CreateService(Service service)
    {
        _logger.LogInformation("Добавление услуги");
        _context.Services.Add(service);
        _context.SaveChanges();
    }

    public void UpdateService(Service service)
    {
        _logger.LogInformation("Редактирование услуги");
        try
        {
            var existing = _context.Services.Find(service.Id);
            if (existing != null)
            {
                _context.Entry(existing).State = EntityState.Detached;
            }
            _context.Services.Update(service);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при редактировании услуги");
            throw;
        }
    }

    public void DeleteService(int id)
    {
        _logger.LogInformation("Удаление услуги");
        var service = _context.Services.Find(id);
        if (service != null)
        {
            _context.Services.Remove(service);
            _context.SaveChanges();
        }
    }

    public Service ReadServiceById(int id) => _context.Services.Find(id);

    public IEnumerable<Service> ReadServices() => _context.Services.ToList();
}
using System.Collections.Generic;
using System.Linq;
using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class ServiceRepository : IServiceRepository
{
    private readonly List<Service> _services = new();

    public IEnumerable<Service> ReadServices() => _services;
    public Service ReadServiceById(int id) => _services.FirstOrDefault(x => x.Id == id)!;
    public void CreateService(Service service) => _services.Add(service);
    public void UpdateService(Service service) { }
    public void DeleteService(int id) => _services.RemoveAll(x => x.Id == id);
}
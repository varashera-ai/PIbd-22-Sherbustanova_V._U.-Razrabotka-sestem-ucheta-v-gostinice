using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IServiceRepository
{
    IEnumerable<Service> ReadServices();
    Service ReadServiceById(int id);
    void CreateService(Service service);
    void UpdateService(Service service);
    void DeleteService(int id);
}
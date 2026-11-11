using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IStayRepository
{
    IEnumerable<Stay> ReadStays(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? roomId = null, int? guestId = null);
    void CreateStay(Stay stay);
    void DeleteStay(int id);
}
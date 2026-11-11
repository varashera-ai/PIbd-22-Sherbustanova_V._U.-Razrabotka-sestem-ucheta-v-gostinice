using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class StayRepository : IStayRepository
{
    public void CreateStay(Stay stay)
    {
    }

    public void DeleteStay(int id)
    {
    }

    public IEnumerable<Stay> ReadStays(DateTime? dateFrom = null, DateTime? dateTo = null,
        int? roomId = null, int? guestId = null)
    {
        return [];
    }
}
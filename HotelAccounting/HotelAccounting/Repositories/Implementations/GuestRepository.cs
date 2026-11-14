using HotelAccounting.Models;
using HotelAccounting.Repositories.Interfaces;

namespace HotelAccounting.Repositories.Implementations;

internal class GuestRepository : IGuestRepository
{
    public void CreateGuest(Guest guest)
    {
    }

    public void DeleteGuest(int id)
    {
    }

    public Guest ReadGuestById(int id)
    {
        return Guest.CreateEntity(0, string.Empty, string.Empty, string.Empty, false);
    }

    public IEnumerable<Guest> ReadGuests()
    {
        return [];
    }

    public void UpdateGuest(Guest guest)
    {
    }
}
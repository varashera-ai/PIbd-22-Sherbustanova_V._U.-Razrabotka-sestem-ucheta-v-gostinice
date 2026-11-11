using HotelAccounting.Models;

namespace HotelAccounting.Repositories.Interfaces;

public interface IGuestRepository
{
    IEnumerable<Guest> ReadGuests();
    Guest ReadGuestById(int id);
    void CreateGuest(Guest guest);
    void UpdateGuest(Guest guest);
    void DeleteGuest(int id);
}
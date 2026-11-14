namespace HotelAccounting.Models;

public class Guest
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string PassportNumber { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public bool IsRegularClient { get; private set; }

    public static Guest CreateEntity(int id, string fullName, string passportNumber, string phone, bool isRegularClient)
    {
        return new Guest
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            PassportNumber = passportNumber ?? string.Empty,
            Phone = phone ?? string.Empty,
            IsRegularClient = isRegularClient
        };
    }
}
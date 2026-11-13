namespace HotelAccounting.Models;

public class Guest
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string PassportNumber { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public bool IsRegularClient { get; set; }

    public Guest() { }

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
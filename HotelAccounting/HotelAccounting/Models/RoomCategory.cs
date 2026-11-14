namespace HotelAccounting.Models;

public class RoomCategory
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int Capacity { get; private set; }
    public decimal PricePerNight { get; private set; }

    public static RoomCategory CreateEntity(int id, string name, int capacity, decimal pricePerNight)
    {
        return new RoomCategory
        {
            Id = id,
            Name = name ?? string.Empty,
            Capacity = capacity,
            PricePerNight = pricePerNight
        };
    }
}
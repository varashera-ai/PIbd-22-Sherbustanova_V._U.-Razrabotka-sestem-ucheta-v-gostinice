namespace HotelAccounting.Models;

public class RoomCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public decimal PricePerNight { get; set; }

    public RoomCategory() { }

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
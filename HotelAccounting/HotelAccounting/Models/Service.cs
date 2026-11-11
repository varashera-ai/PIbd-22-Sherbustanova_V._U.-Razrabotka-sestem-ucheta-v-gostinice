using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Service
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public AdditionalServices ServiceType { get; private set; }

    public static Service CreateEntity(int id, string name, decimal price, AdditionalServices serviceType)
    {
        return new Service
        {
            Id = id,
            Name = name ?? string.Empty,
            Price = price,
            ServiceType = serviceType
        };
    }
}
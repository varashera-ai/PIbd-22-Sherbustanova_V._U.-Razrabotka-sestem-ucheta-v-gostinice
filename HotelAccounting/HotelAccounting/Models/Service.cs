using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public AdditionalServices ServiceType { get; set; }

    public Service() { }

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
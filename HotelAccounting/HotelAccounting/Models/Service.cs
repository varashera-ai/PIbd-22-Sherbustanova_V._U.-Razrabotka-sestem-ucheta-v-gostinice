using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelAccounting.Enums;

namespace HotelAccounting.Models;

public class Service
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Column("price")]
    public decimal Price { get; set; }

    [Required]
    [Column("servicetype")]
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
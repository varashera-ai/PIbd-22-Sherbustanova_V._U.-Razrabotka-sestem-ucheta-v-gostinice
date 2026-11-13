using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAccounting.Models;

public class RoomCategory
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Column("capacity")]
    public int Capacity { get; set; }

    [Required]
    [Column("pricepernight")]
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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelAccounting.Models;

public class StayService
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Stay")]
    [Column("stayid")]
    public int StayId { get; set; }

    [Required]
    [ForeignKey("Service")]
    [Column("serviceid")]
    public int ServiceId { get; set; }

    [Required]
    [Column("quantity")]
    public int Quantity { get; set; }

    public StayService() { }

    public static StayService CreateElement(int id, int stayId, int serviceId, int quantity)
    {
        return new StayService
        {
            Id = id,
            StayId = stayId,
            ServiceId = serviceId,
            Quantity = quantity
        };
    }
}
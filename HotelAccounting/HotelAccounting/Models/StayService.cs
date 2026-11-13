namespace HotelAccounting.Models;

public class StayService
{
    public int Id { get; set; }
    public int StayId { get; set; }
    public int ServiceId { get; set; }
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
namespace HotelAccounting.Models;

public class StayService
{
    public int Id { get; private set; }
    public int StayId { get; private set; }
    public int ServiceId { get; private set; }
    public int Quantity { get; private set; }

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
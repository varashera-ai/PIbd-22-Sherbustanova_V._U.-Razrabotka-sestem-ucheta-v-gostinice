using Unity;
using HotelAccounting.Repositories.Interfaces;
using HotelAccounting.Repositories.Implementations;

namespace HotelAccounting;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(CreateContainer().Resolve<MainForm>());
    }

    private static IUnityContainer CreateContainer()
    {
        var container = new UnityContainer();

        container.RegisterType<IRoomCategoryRepository, RoomCategoryRepository>();
        container.RegisterType<IRoomRepository, RoomRepository>();
        container.RegisterType<IGuestRepository, GuestRepository>();
        container.RegisterType<IServiceRepository, ServiceRepository>();
        container.RegisterType<IBookingRepository, BookingRepository>();
        container.RegisterType<IStayRepository, StayRepository>();
        container.RegisterType<FormRoomCategories>();
        container.RegisterType<FormRoomCategory>();
        container.RegisterType<FormRooms>();
        container.RegisterType<FormRoom>();
        container.RegisterType<FormServices>();
        container.RegisterType<FormService>();
        container.RegisterType<FormGuests>();
        container.RegisterType<FormGuest>();
        container.RegisterType<FormBookings>();
        container.RegisterType<FormBooking>();
        container.RegisterType<FormStays>();
        container.RegisterType<FormStay>();
        return container;
    }
}
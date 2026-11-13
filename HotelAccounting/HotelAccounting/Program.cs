using Unity;
using Unity.Microsoft.Logging;
using Serilog;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;
using HotelAccounting.Repositories.Interfaces;
using HotelAccounting.Repositories.Implementations;
using Unity.Lifetime;
using HotelAccounting.Repositories;
using HotelAccounting.Data; // <-- днаюбкемн дкъ DATACONTEXT

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

        container.AddExtension(new LoggingExtension(CreateLoggerFactory()));
        container.RegisterType<IConnectionString, DbConnectionString>(new SingletonLifetimeManager());
        container.RegisterType<DataContext>(new TransientLifetimeManager());

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

    private static LoggerFactory CreateLoggerFactory()
    {
        var configPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
        if (!File.Exists(configPath))
        {
            var sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "appsettings.json");
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, configPath, true);
            }
        }

        var loggerFactory = new LoggerFactory();
        loggerFactory.AddSerilog(new LoggerConfiguration()
            .ReadFrom.Configuration(new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build())
            .CreateLogger());
        return loggerFactory;
    }
}
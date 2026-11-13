using HotelAccounting.Repositories;

namespace HotelAccounting.Repositories.Implementations
{

    internal class DbConnectionString : IConnectionString
    {
        public string ConnectionString => "Host=172.20.10.2;Port=5432;Database=HotelDB;Username=postgres;Password=123;";
    }
}
using System;

namespace HotelAccounting.Enums;

[Flags]
public enum AdditionalServices
{
    None = 0,
    MiniBar = 1,
    Laundry = 2,
    Transfer = 4
}
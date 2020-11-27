
using System;

namespace DAL.Core
{
    public enum Gender
    {
        None,
        Female,
        Male
    }

    public enum TripStatus
    {
        Requested, Accepted, Enroute, Cancelled, Completed
    }

    public enum AccountStatus
    {
        Pending, Active, Suspended, InActive
    }
}

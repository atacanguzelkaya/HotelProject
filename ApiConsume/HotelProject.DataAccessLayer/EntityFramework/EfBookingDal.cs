using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfBookingDal : GenericRepository<Booking>, IBookingDal
{
    public EfBookingDal(Context context) : base(context)
    {
        
    }

    public int GetBookingCount()
    {
        var context = new Context();
        var value = context.Bookings.Count();
        return value;
    }

    public List<Booking> Last6Bookings()
    {
        var context = new Context();
        var values = context.Bookings.OrderByDescending(x => x.BookingId).Take(6).ToList();
        return values;
    }
}
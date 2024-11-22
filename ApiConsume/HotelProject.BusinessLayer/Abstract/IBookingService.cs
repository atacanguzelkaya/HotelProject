using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract;

public interface IBookingService:IGenericService<Booking>
{
    int TGetBookingCount();
    List<Booking> TLast6Bookings();
}
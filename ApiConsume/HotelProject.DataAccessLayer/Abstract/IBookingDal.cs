using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract;

public interface IBookingDal : IGenericDal<Booking>
{
    int GetBookingCount();
    List<Booking> Last6Bookings();
    void BookingStatusChangeApproved(int id);
    void BookingStatusChangeCancel(int id);
    void BookingStatusChangeWait(int id);
}
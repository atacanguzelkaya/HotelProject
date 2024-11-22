using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
{
    public EfAppUserDal(Context context) : base(context)
    {       
    }

    public int AppUserCount()
    {
        var context = new Context();
        var value = context.Users.Count();
        return value;
    }
}
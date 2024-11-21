﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
{
    public EfAppUserDal(Context context) : base(context)
    {       
    }
}
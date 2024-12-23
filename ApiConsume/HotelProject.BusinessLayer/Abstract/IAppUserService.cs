﻿using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Abstract;

public interface IAppUserService:IGenericService<AppUser>
{
    int TAppUserCount();
}
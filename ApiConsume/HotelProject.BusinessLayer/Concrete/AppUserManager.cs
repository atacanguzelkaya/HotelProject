﻿using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class AppUserManager : IAppUserService
{
	private readonly IAppUserDal _appUserDal;

	public AppUserManager(IAppUserDal appUserDal)
	{
		_appUserDal = appUserDal;
	}

    public int TAppUserCount()
    {
		return _appUserDal.AppUserCount();
    }

    public void TDelete(AppUser t)
	{
		_appUserDal.Delete(t);
	}

	public AppUser TGetById(int id)
	{
		return _appUserDal.GetById(id);
	}

	public List<AppUser> TGetList()
	{
		return _appUserDal.GetList();
	}

	public void TInsert(AppUser t)
	{
		_appUserDal.Insert(t);
	}

	public void TUpdate(AppUser t)
	{
		_appUserDal.Update(t);
	}
}

using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Dtos.AppUser;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppUserController : ControllerBase
	{
		private readonly IAppUserService _appUserService;
		public AppUserController(IAppUserService appUserService)
		{
			_appUserService = appUserService;
		}

		[HttpGet]
		public IActionResult AppUserList()
		{
			var values = _appUserService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddAppUser(AppUser appUser)
		{
			_appUserService.TInsert(appUser);
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteAppUser(int id)
		{
			var values = _appUserService.TGetById(id);
			_appUserService.TDelete(values);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateAppUser(AppUser appUser)
		{
			_appUserService.TUpdate(appUser);
			return Ok();
		}
		[HttpGet("{id}")]
		public IActionResult GetAppUser(int id)
		{
			var values = _appUserService.TGetById(id);
			return Ok(values);
		}
        [HttpGet("AppUserWithLocation")]
        public IActionResult AppUserWithLocation()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new ResultAppUserWithWorkLocationDto
            {
                Name = y.Name,
                Surname = y.Surname,
                WorkLocationId = y.WorkLocationId,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                City = y.City,
                Country = y.Country,
                Gender = y.Gender,
                ImageUrl = y.ImageUrl
            }).ToList();
            return Ok(values);
        }
    }
}

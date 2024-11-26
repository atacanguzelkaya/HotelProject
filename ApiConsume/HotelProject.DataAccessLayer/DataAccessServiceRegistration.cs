using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.DataAccessLayer
{
	public static class DataAccessServiceRegistration
	{
		public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
		{
			services.AddScoped<IRoomDal, EfRoomDal>();
			services.AddScoped<IStaffDal, EfStaffDal>();
			services.AddScoped<IServiceDal, EfServiceDal>();
			services.AddScoped<ISubscribeDal, EfSubscribeDal>();
			services.AddScoped<ITestimonialDal, EfTestimonialDal>();
			services.AddScoped<IAboutDal, EfAboutDal>();
			services.AddScoped<IBookingDal, EfBookingDal>();
			services.AddScoped<IGuestDal, EfGuestDal>();
			services.AddScoped<IContactDal, EfContactDal>();
			services.AddScoped<ISendMessageDal, EfSendMessageDal>();
			services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
			services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
			services.AddScoped<IAppUserDal, EfAppUserDal>();
			return services;
		}
	}
}
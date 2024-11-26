using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.BusinessLayer
{
	public static class BusinessServiceRegistration
	{
		public static IServiceCollection AddBusinessServices(this IServiceCollection services)
		{
			services.AddScoped<IRoomService, RoomManager>();
			services.AddScoped<IStaffService, StaffManager>();
			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<ISubscribeService, SubscribeManager>();
			services.AddScoped<ITestimonialService, TestimonialManager>();
			services.AddScoped<IAboutService, AboutManager>();
			services.AddScoped<IBookingService, BookingManager>();
			services.AddScoped<IGuestService, GuestManager>();
			services.AddScoped<IContactService, ContactManager>();
			services.AddScoped<ISendMessageService, SendMessageManager>();
			services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
			services.AddScoped<IWorkLocationService, WorkLocationManager>();
			services.AddScoped<IAppUserService, AppUserManager>();
			return services;
		}
	}
}
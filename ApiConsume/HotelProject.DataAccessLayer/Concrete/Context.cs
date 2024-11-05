using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete;

public class Context:DbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial catalog=HotelProjectDb;integrated security=true");
	}
}
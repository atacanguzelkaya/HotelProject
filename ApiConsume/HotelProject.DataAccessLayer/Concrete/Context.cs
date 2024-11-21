﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete;

public class Context:IdentityDbContext<AppUser, AppRole, int>
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Subscribe> Subscribes { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<SendMessage> SendMessages { get; set; }
    public DbSet<MessageCategory> MessageCategories { get; set; }
    public DbSet<WorkLocation> WorkLocations { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial catalog=HotelProjectDb;integrated security=true");
	}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Room>(entry =>
        {
            entry.ToTable("Rooms", tb => tb.HasTrigger("RoomsCountTrigger"));
        });
        builder.Entity<Staff>(entry =>
        {
            entry.ToTable("Staffs", tb => tb.HasTrigger("StaffsCountTrigger"));
        });
        builder.Entity<Guest>(entry =>
        {
            entry.ToTable("Guests", tb => tb.HasTrigger("GuestsCountTrigger"));
        });
    }
}
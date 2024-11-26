using HotelProject.BusinessLayer;
using HotelProject.DataAccessLayer;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.WebApi.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddDataAccessServices();
builder.Services.AddBusinessServices();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddCors(opt =>
{
	opt.AddPolicy("HotelApiCors", opts =>
	{
		opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
	});
});

builder.Services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseCors("HotelApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
using Microsoft.EntityFrameworkCore;
using Myapp.BusinessLayer.Interface;
using Myapp.BusinessLayer.Mapper;
using Myapp.BusinessLayer.Services;
using Myapp.DataAccess.HotelDbContext;
using Myapp.DataAccess.Interface;
using Myapp.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();

    });
});
#endregion

#region DbContext

builder.Services.AddDbContext<HotelAdminDbContext>(Option =>
Option.UseNpgsql(builder.Configuration.GetConnectionString("DataBaseConnectionString")));

#endregion

#region Dependency Injection

builder.Services.AddScoped<IHotelManagement, HotelManagementAdmin>();
builder.Services.AddScoped<IRepository, HotelAdminRepository>();

builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IBookingServices, BookingServices>();
builder.Services.AddScoped<IBookingRepository,BookingRepository>();

#endregion

#region Automapper

builder.Services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

#endregion

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();

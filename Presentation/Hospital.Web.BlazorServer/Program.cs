using System.Reflection;
using Hospital.Application.Commands;
using Hospital.Domain.Core.Repositories.Commands;
using Hospital.Domain.Core.Repositories.Commands.Base;
using Hospital.Domain.Core.Repositories.Queries;
using Hospital.Domain.Core.Repositories.Queries.Base;
using Hospital.Infrastructure.Data;
using Hospital.Infrastructure.Repositories.Commands;
using Hospital.Infrastructure.Repositories.Commands.Base;
using Hospital.Infrastructure.Repositories.Queries;
using Hospital.Infrastructure.Repositories.Queries.Base;
using Hospital.Web.BlazorServer.Logic;
using Hospital.Web.BlazorServer.Models;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor().AddCircuitOptions(e =>
{
    e.DetailedErrors = true;
});
builder.Services.AddHttpContextAccessor();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 5000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 200;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});

builder.Services.AddDbContext<HospitalContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.EnableSensitiveDataLogging();
});

builder.Services.AddScoped<IAccountLogic, AccountLogic>();
builder.Services.AddScoped<TokenProvider>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.ExpireTimeSpan = TimeSpan.FromDays(20);
    });
builder.Services.AddHttpClient();

// Register dependencies
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMediatR(typeof(CreateUserCommand).GetTypeInfo().Assembly);

builder.Services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));

builder.Services.AddTransient<IUserQueryRepository, UserQueryRepository>();
builder.Services.AddTransient<IUserCommandRepository, UserCommandRepository>();

builder.Services.AddTransient<IRoleQueryRepository, RoleQueryRepository>();
builder.Services.AddTransient<IRoleCommandRepository, RoleCommandRepository>();

builder.Services.AddTransient<IDepartmentQueryRepository, DepartmentQueryRepository>();
builder.Services.AddTransient<IDepartmentCommandRepository, DepartmentCommandRepository>();

builder.Services.AddTransient<IServiceQueryRepository, ServiceQueryRepository>();
builder.Services.AddTransient<IServiceCommandRepository, ServiceCommandRepository>();

builder.Services.AddTransient<IRoomTypeQueryRepository, RoomTypeQueryRepository>();
builder.Services.AddTransient<IRoomTypeCommandRepository, RoomTypeCommandRepository>();

builder.Services.AddTransient<IRoomQueryRepository, RoomQueryRepository>();
builder.Services.AddTransient<IRoomCommandRepository, RoomCommandRepository>();

builder.Services.AddTransient<IHospitalInformationQueryRepository, HospitalInformationQueryRepository>();
builder.Services.AddTransient<IHospitalInformationCommandRepository, HospitalInformationCommandRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var webSocketOptions = new WebSocketOptions()
{
    KeepAliveInterval = TimeSpan.FromSeconds(120),
};
app.UseWebSockets(webSocketOptions);

app.Run();

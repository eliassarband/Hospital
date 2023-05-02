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
},ServiceLifetime.Transient);

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

builder.Services.AddTransient<IUserRoleQueryRepository, UserRoleQueryRepository>();
builder.Services.AddTransient<IUserRoleCommandRepository, UserRoleCommandRepository>();

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

builder.Services.AddTransient<IAttachmentQueryRepository, AttachmentQueryRepository>();
builder.Services.AddTransient<IAttachmentCommandRepository, AttachmentCommandRepository>();

builder.Services.AddTransient<IBasicInformationCategoryQueryRepository, BasicInformationCategoryQueryRepository>();
builder.Services.AddTransient<IBasicInformationCategoryCommandRepository, BasicInformationCategoryCommandRepository>();

builder.Services.AddTransient<IBasicInformationQueryRepository, BasicInformationQueryRepository>();
builder.Services.AddTransient<IBasicInformationCommandRepository, BasicInformationCommandRepository>();

builder.Services.AddTransient<IInsuranceQueryRepository, InsuranceQueryRepository>();
builder.Services.AddTransient<IInsuranceCommandRepository, InsuranceCommandRepository>();

builder.Services.AddTransient<IInsuranceAgreementQueryRepository, InsuranceAgreementQueryRepository>();
builder.Services.AddTransient<IInsuranceAgreementCommandRepository, InsuranceAgreementCommandRepository>();

builder.Services.AddTransient<IStaffQueryRepository, StaffQueryRepository>();
builder.Services.AddTransient<IStaffCommandRepository, StaffCommandRepository>();

builder.Services.AddTransient<IStaffTimingQueryRepository, StaffTimingQueryRepository>();
builder.Services.AddTransient<IStaffTimingCommandRepository, StaffTimingCommandRepository>();

builder.Services.AddTransient<IRefferByQueryRepository, RefferByQueryRepository>();
builder.Services.AddTransient<IRefferByCommandRepository, RefferByCommandRepository>();

builder.Services.AddTransient<IPatientQueryRepository, PatientQueryRepository>();
builder.Services.AddTransient<IPatientCommandRepository, PatientCommandRepository>();

builder.Services.AddTransient<IOPDBillQueryRepository, OPDBillQueryRepository>();
builder.Services.AddTransient<IOPDBillCommandRepository, OPDBillCommandRepository>();

builder.Services.AddTransient<IOPDBillServiceQueryRepository, OPDBillServiceQueryRepository>();
builder.Services.AddTransient<IOPDBillServiceCommandRepository, OPDBillServiceCommandRepository>();

builder.Services.AddTransient<IReportTemplateQueryRepository, ReportTemplateQueryRepository>();
builder.Services.AddTransient<IReportTemplateCommandRepository, ReportTemplateCommandRepository>();

builder.Services.AddTransient<IIPDRegisterationQueryRepository, IPDRegisterationQueryRepository>();
builder.Services.AddTransient<IIPDRegisterationCommandRepository, IPDRegisterationCommandRepository>();

builder.Services.AddTransient<IIPDRegisterationServiceQueryRepository, IPDRegisterationServiceQueryRepository>();
builder.Services.AddTransient<IIPDRegisterationServiceCommandRepository, IPDRegisterationServiceCommandRepository>();

builder.Services.AddTransient<IIPDRegisterationRoomQueryRepository, IPDRegisterationRoomQueryRepository>();
builder.Services.AddTransient<IIPDRegisterationRoomCommandRepository, IPDRegisterationRoomCommandRepository>();

builder.Services.AddTransient<IIPDRegisterationPaymentQueryRepository, IPDRegisterationPaymentQueryRepository>();
builder.Services.AddTransient<IIPDRegisterationPaymentCommandRepository, IPDRegisterationPaymentCommandRepository>();

builder.Services.AddTransient<ISettingQueryRepository, SettingQueryRepository>();
builder.Services.AddTransient<ISettingCommandRepository, SettingCommandRepository>();

builder.Services.AddTransient<IBedQueryRepository, BedQueryRepository>();
builder.Services.AddTransient<IBedCommandRepository, BedCommandRepository>();

builder.Services.AddTransient<IOPDBillPaymentQueryRepository, OPDBillPaymentQueryRepository>();
builder.Services.AddTransient<IOPDBillPaymentCommandRepository, OPDBillPaymentCommandRepository>();

builder.Services.AddTransient<IGroupQueryRepository, GroupQueryRepository>();
builder.Services.AddTransient<IGroupCommandRepository, GroupCommandRepository>();

builder.Services.AddTransient<IGroupUserQueryRepository, GroupUserQueryRepository>();
builder.Services.AddTransient<IGroupUserCommandRepository, GroupUserCommandRepository>();

builder.Services.AddTransient<IFormCategoryQueryRepository, FormCategoryQueryRepository>();
builder.Services.AddTransient<IFormCategoryCommandRepository, FormCategoryCommandRepository>();

builder.Services.AddTransient<IFormQueryRepository, FormQueryRepository>();
builder.Services.AddTransient<IFormCommandRepository, FormCommandRepository>();

builder.Services.AddTransient<IFormActionQueryRepository, FormActionQueryRepository>();
builder.Services.AddTransient<IFormActionCommandRepository, FormActionCommandRepository>();

builder.Services.AddTransient<IFormActionAccessQueryRepository, FormActionAccessQueryRepository>();
builder.Services.AddTransient<IFormActionAccessCommandRepository, FormActionAccessCommandRepository>();


//Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHkgpgFGkUl79uxVs8X+uspx6K+tqdtOB5G1S6PFPRrlVNvMUiSiNYl724EZbrUAWwAYHlGLRbvxMviMExTh2l9xZJ2xc4K1z3ZVudRpQpuDdFq+fe0wKXSKlB6okl0hUd2ikQHfyzsAN8fJltqvGRa5LI8BFkA/f7tffwK6jzW5xYYhHxQpU3hy4fmKo/BSg6yKAoUq3yMZTG6tWeKnWcI6ftCDxEHd30EjMISNn1LCdLN0/4YmedTjM7x+0dMiI2Qif/yI+y8gmdbostOE8S2ZjrpKsgxVv2AAZPdzHEkzYSzx81RHDzZBhKRZc5mwWAmXsWBFRQol9PdSQ8BZYLqvJ4Jzrcrext+t1ZD7HE1RZPLPAqErO9eo+7Zn9Cvu5O73+b9dxhE2sRyAv9Tl1lV2WqMezWRsO55Q3LntawkPq0HvBkd9f8uVuq9zk7VKegetCDLb0wszBAs1mjWzN+ACVHiPVKIk94/QlCkj31dWCg8YTrT5btsKcLibxog7pv1+2e4yocZKWsposmcJbgG0";

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

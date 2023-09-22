using DWNet.Data.AspNetCore;
using SnapObjects.Data;
using SnapObjects.Data.AspNetCore;
using SnapObjects.Data.SqlServer;
using System.IO.Compression;
using Open2HRRestAPI;
using Open2HRRestAPI.Services;
using Open2HRRestAPI.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(m =>
{
	m.UseCoreIntegrated();
    m.UsePowerBuilderIntegrated();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Uncomment the following line to connect to the SQL server database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
builder.Services.AddDataContext<SampleDataContext>(m => m.UseSqlServer(builder.Configuration, "TH-DE-02709\\STAM_SERVER.Adeies"));

// Services scope declaration
builder.Services.AddScoped<IDddw_Supervisor_NamesService, Dddw_Supervisor_NamesService>();
builder.Services.AddScoped<IDw_Admin_Create_Hr_AcountService, Dw_Admin_Create_Hr_AcountService>();
builder.Services.AddScoped<IDw_Admin_Employee_CreateService, Dw_Admin_Employee_CreateService>();
builder.Services.AddScoped<IDw_Admin_Employees_WithoutusersService, Dw_Admin_Employees_WithoutusersService>();
builder.Services.AddScoped<IDw_Admin_Grid_EmployeesService, Dw_Admin_Grid_EmployeesService>();
builder.Services.AddScoped<IDw_Admin_Grid_UsersService, Dw_Admin_Grid_UsersService>();
builder.Services.AddScoped<IDw_AuthService, Dw_AuthService>();
builder.Services.AddScoped<IDw_BalanceService, Dw_BalanceService>();
builder.Services.AddScoped<IDw_Category_SelectService, Dw_Category_SelectService>();
builder.Services.AddScoped<IDw_Dddw_Leave_StatusService, Dw_Dddw_Leave_StatusService>();
builder.Services.AddScoped<IDw_Dddw_Leaves_CategoryService, Dw_Dddw_Leaves_CategoryService>();
builder.Services.AddScoped<IDw_Employee_LeavesService, Dw_Employee_LeavesService>();
builder.Services.AddScoped<IDw_Employee_RegistryService, Dw_Employee_RegistryService>();
builder.Services.AddScoped<IDw_Employee_SupervisorService, Dw_Employee_SupervisorService>();
builder.Services.AddScoped<IDw_Employee_Sv_GridService, Dw_Employee_Sv_GridService>();
builder.Services.AddScoped<IDw_Grid_Adeies_IfistamenonService, Dw_Grid_Adeies_IfistamenonService>();
builder.Services.AddScoped<IDw_Hr_Employees_Wo_UsersService, Dw_Hr_Employees_Wo_UsersService>();
builder.Services.AddScoped<IDw_Hr_ShowleavecategoriesService, Dw_Hr_ShowleavecategoriesService>();
builder.Services.AddScoped<IDw_LoginService, Dw_LoginService>();
builder.Services.AddScoped<IDw_My_SecurityService, Dw_My_SecurityService>();
builder.Services.AddScoped<IDw_New_Employee_BalanceService, Dw_New_Employee_BalanceService>();
builder.Services.AddScoped<IDw_New_EmployeeService, Dw_New_EmployeeService>();
builder.Services.AddScoped<IDw_ProfileService, Dw_ProfileService>();
builder.Services.AddScoped<IDw_Request_HistoryService, Dw_Request_HistoryService>();
builder.Services.AddScoped<IDw_RequestService, Dw_RequestService>();
builder.Services.AddScoped<IDw_SequenceService, Dw_SequenceService>();
builder.Services.AddScoped<IDw_Supervisor_LeavesService, Dw_Supervisor_LeavesService>();
builder.Services.AddScoped<IDw_Supervisor_SelectService, Dw_Supervisor_SelectService>();
builder.Services.AddScoped<IDw_SupervisorService, Dw_SupervisorService>();

builder.Services.AddGzipCompression(CompressionLevel.Fastest);

// Begin App
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseResponseCompression();

app.UseDataWindow();

app.Run();

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

// Uncomment the following line to connect to the Oracle database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UseOracle(builder.Configuration, "Local"));

// Uncomment the following line to connect to the PostGreSql database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UsePostgreSql(builder.Configuration, "Local"));

// Uncomment the following line to connect to the SqlAnywhere database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UseSqlAnywhere(builder.Configuration, "Local"));
			
// Uncomment the following line to connect to the Ase database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UseAse(builder.Configuration, "Local"));
			
// Uncomment the following line to connect to the Sqlite database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UseSqlite(builder.Configuration, "Local"));
			
// Uncomment the following line to connect to the MySql database.
// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
// builder.Services.AddDataContext<ContextName>(m => m.UseMySql(builder.Configuration, "Local"));

builder.Services.AddScoped<IDddw_Supervisor_NamesService, Dddw_Supervisor_NamesService>();
builder.Services.AddScoped<IDw_Admin_Create_Hr_AcountService, Dw_Admin_Create_Hr_AcountService>();
builder.Services.AddScoped<IDw_Admin_Employee_CreateService, Dw_Admin_Employee_CreateService>();
builder.Services.AddScoped<IDw_Admin_Employees_WithoutusersService, Dw_Admin_Employees_WithoutusersService>();
builder.Services.AddScoped<IDw_Admin_Grid_EmployeesService, Dw_Admin_Grid_EmployeesService>();

builder.Services.AddGzipCompression(CompressionLevel.Fastest);

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

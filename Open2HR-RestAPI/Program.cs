using DWNet.Data.AspNetCore;
using SnapObjects.Data;
using SnapObjects.Data.AspNetCore;
using SnapObjects.Data.SqlServer;
using System.IO.Compression;
using Open2HRRestAPI;
using Open2HRRestAPI.Services;
using Open2HRRestAPI.Services.Impl;

//var builder = WebApplication.CreateBuilder(args);

namespace FromPBtoCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });

    }
}

//// Add services to the container.

//builder.Services.AddControllers(m =>
//{
//	m.UseCoreIntegrated();
//    m.UsePowerBuilderIntegrated();
//});
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();


//// Uncomment the following line to connect to the SQL server database.
//// Note: Replace "ContextName" with the configured context name; replace "Local" with the database connection name that exists in appsettings.json. The sample code is as follows:
//builder.Services.AddDataContext<SampleDataContext>(m => m.UseSqlServer(builder.Configuration, "TH-DE-02709\\STAM_SERVER.Adeies"));

//// Services scope declaration


//builder.Services.AddGzipCompression(CompressionLevel.Fastest);

//// Begin App
//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.UseResponseCompression();

//app.UseDataWindow();

//app.Run();

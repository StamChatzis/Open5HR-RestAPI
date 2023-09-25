using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DWNet.Data.AspNetCore;
using SnapObjects.Data;
using SnapObjects.Data.AspNetCore;
using SnapObjects.Data.SqlServer;
using Open2HRRestAPI;
using Open2HRRestAPI.Services;
using Open2HRRestAPI.Services.Impl;

namespace FromPBtoCSharp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataContext<SampleDataContext>(m => m.UseSqlServer(Configuration, "TH-DE-02705\\SIMOS.Adeies"));
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            
            services.AddCors(opts =>
            {
                opts.AddPolicy("AllowCors", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddScoped<IDddw_Supervisor_NamesService, Dddw_Supervisor_NamesService>();
            services.AddScoped<IDw_Admin_Create_Hr_AcountService, Dw_Admin_Create_Hr_AcountService>();
            services.AddScoped<IDw_Admin_Employee_CreateService, Dw_Admin_Employee_CreateService>();
            services.AddScoped<IDw_Admin_Employees_WithoutusersService, Dw_Admin_Employees_WithoutusersService>();
            services.AddScoped<IDw_Admin_Grid_EmployeesService, Dw_Admin_Grid_EmployeesService>();
            services.AddScoped<IDw_Admin_Grid_UsersService, Dw_Admin_Grid_UsersService>();
            services.AddScoped<IDw_AuthService, Dw_AuthService>();
            services.AddScoped<IDw_BalanceService, Dw_BalanceService>();
            services.AddScoped<IDw_Category_SelectService, Dw_Category_SelectService>();
            services.AddScoped<IDw_Dddw_Leave_StatusService, Dw_Dddw_Leave_StatusService>();
            services.AddScoped<IDw_Dddw_Leaves_CategoryService, Dw_Dddw_Leaves_CategoryService>();
            services.AddScoped<IDw_Employee_LeavesService, Dw_Employee_LeavesService>();
            services.AddScoped<IDw_Employee_RegistryService, Dw_Employee_RegistryService>();
            services.AddScoped<IDw_Employee_SupervisorService, Dw_Employee_SupervisorService>();
            services.AddScoped<IDw_Employee_Sv_GridService, Dw_Employee_Sv_GridService>();
            services.AddScoped<IDw_Grid_Adeies_IfistamenonService, Dw_Grid_Adeies_IfistamenonService>();
            services.AddScoped<IDw_Hr_Employees_Wo_UsersService, Dw_Hr_Employees_Wo_UsersService>();
            services.AddScoped<IDw_Hr_ShowleavecategoriesService, Dw_Hr_ShowleavecategoriesService>();
            services.AddScoped<IDw_My_SecurityService, Dw_My_SecurityService>();
            services.AddScoped<IDw_New_Employee_BalanceService, Dw_New_Employee_BalanceService>();
            services.AddScoped<IDw_New_EmployeeService, Dw_New_EmployeeService>();
            services.AddScoped<IDw_ProfileService, Dw_ProfileService>();
            services.AddScoped<IDw_Request_HistoryService, Dw_Request_HistoryService>();
            services.AddScoped<IDw_RequestService, Dw_RequestService>();
            services.AddScoped<IDw_SequenceService, Dw_SequenceService>();
            services.AddScoped<IDw_Supervisor_LeavesService, Dw_Supervisor_LeavesService>();
            services.AddScoped<IDw_Supervisor_SelectService, Dw_Supervisor_SelectService>();
            services.AddScoped<IDw_SupervisorService, Dw_SupervisorService>();
            
            services.AddControllers(m =>
            {
                m.UseCoreIntegrated();
            });
            
            services.AddGzipCompression(CompressionLevel.Fastest);
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseRouting();
            app.UseCors("AllowCors");
            app.UseAuthorization();
            app.UseResponseCompression();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseHttpsRedirection();
            app.UseDataWindow();
        }
    }
}

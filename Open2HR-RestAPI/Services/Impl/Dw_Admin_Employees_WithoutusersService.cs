using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<Dw_Admin_Employees_WithoutusersService>, Dw_Admin_Employees_WithoutusersService>();
    /// </summary>  
    public class Dw_Admin_Employees_WithoutusersService : IDw_Admin_Employees_WithoutusersService
    {
        private readonly DataContext _dataContext;
        public Dw_Admin_Employees_WithoutusersService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Admin_Employees_Withoutusers>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Admin_Employees_Withoutusers>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
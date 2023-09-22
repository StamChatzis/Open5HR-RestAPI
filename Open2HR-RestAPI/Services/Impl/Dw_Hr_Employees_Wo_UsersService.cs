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
    /// services.AddScoped<I<Dw_Hr_Employees_Wo_UsersService>, Dw_Hr_Employees_Wo_UsersService>();
    /// </summary>  
    public class Dw_Hr_Employees_Wo_UsersService : IDw_Hr_Employees_Wo_UsersService
    {
        private readonly DataContext _dataContext;
        public Dw_Hr_Employees_Wo_UsersService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Hr_Employees_Wo_Users>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Hr_Employees_Wo_Users>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
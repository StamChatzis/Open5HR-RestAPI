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
    /// services.AddScoped<I<Dw_Supervisor_SelectService>, Dw_Supervisor_SelectService>();
    /// </summary>  
    public class Dw_Supervisor_SelectService : IDw_Supervisor_SelectService
    {
        private readonly DataContext _dataContext;
        public Dw_Supervisor_SelectService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Supervisor_Select>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Supervisor_Select>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
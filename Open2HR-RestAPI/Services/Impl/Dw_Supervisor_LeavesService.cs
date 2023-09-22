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
    /// services.AddScoped<I<Dw_Supervisor_LeavesService>, Dw_Supervisor_LeavesService>();
    /// </summary>  
    public class Dw_Supervisor_LeavesService : IDw_Supervisor_LeavesService
    {
        private readonly DataContext _dataContext;
        public Dw_Supervisor_LeavesService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Supervisor_Leaves>> RetrieveAsync(double? an_ID, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Supervisor_Leaves>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_ID }, cancellationToken);

            return dataStore;
        }
    }  
}
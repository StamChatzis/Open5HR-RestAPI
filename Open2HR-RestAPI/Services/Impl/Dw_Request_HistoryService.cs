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
    /// services.AddScoped<I<Dw_Request_HistoryService>, Dw_Request_HistoryService>();
    /// </summary>  
    public class Dw_Request_HistoryService : IDw_Request_HistoryService
    {
        private readonly DataContext _dataContext;
        public Dw_Request_HistoryService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Request_History>> RetrieveAsync(double? an_id, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Request_History>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_id }, cancellationToken);

            return dataStore;
        }
    }  
}
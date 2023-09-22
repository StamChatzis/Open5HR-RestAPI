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
    /// services.AddScoped<I<Dw_My_SecurityService>, Dw_My_SecurityService>();
    /// </summary>  
    public class Dw_My_SecurityService : IDw_My_SecurityService
    {
        private readonly DataContext _dataContext;
        public Dw_My_SecurityService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_My_Security>> RetrieveAsync(double? an_id, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_My_Security>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_id }, cancellationToken);

            return dataStore;
        }
    }  
}
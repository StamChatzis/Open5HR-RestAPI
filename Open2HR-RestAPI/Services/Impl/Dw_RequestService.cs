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
    /// services.AddScoped<I<Dw_RequestService>, Dw_RequestService>();
    /// </summary>  
    public class Dw_RequestService : PbServiceBase<Dw_Request>, IDw_RequestService
    {
        public Dw_RequestService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Request>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Request>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
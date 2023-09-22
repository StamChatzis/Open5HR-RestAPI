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
    /// services.AddScoped<I<Dw_Dddw_Leave_StatusService>, Dw_Dddw_Leave_StatusService>();
    /// </summary>  
    public class Dw_Dddw_Leave_StatusService : PbServiceBase<Dw_Dddw_Leave_Status>, IDw_Dddw_Leave_StatusService
    {
        public Dw_Dddw_Leave_StatusService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Dddw_Leave_Status>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Dddw_Leave_Status>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
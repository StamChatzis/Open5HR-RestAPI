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
    /// services.AddScoped<I<Dw_Employee_Sv_GridService>, Dw_Employee_Sv_GridService>();
    /// </summary>  
    public class Dw_Employee_Sv_GridService : PbServiceBase<Dw_Employee_Sv_Grid>, IDw_Employee_Sv_GridService
    {
        public Dw_Employee_Sv_GridService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Employee_Sv_Grid>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Employee_Sv_Grid>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
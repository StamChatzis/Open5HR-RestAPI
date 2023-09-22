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
    /// services.AddScoped<I<Dw_Dddw_Leaves_CategoryService>, Dw_Dddw_Leaves_CategoryService>();
    /// </summary>  
    public class Dw_Dddw_Leaves_CategoryService : PbServiceBase<Dw_Dddw_Leaves_Category>, IDw_Dddw_Leaves_CategoryService
    {
        public Dw_Dddw_Leaves_CategoryService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Dddw_Leaves_Category>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Dddw_Leaves_Category>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
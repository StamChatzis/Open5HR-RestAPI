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
    /// services.AddScoped<I<Dw_Hr_ShowleavecategoriesService>, Dw_Hr_ShowleavecategoriesService>();
    /// </summary>  
    public class Dw_Hr_ShowleavecategoriesService : PbServiceBase<Dw_Hr_Showleavecategories>, IDw_Hr_ShowleavecategoriesService
    {
        public Dw_Hr_ShowleavecategoriesService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Hr_Showleavecategories>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Hr_Showleavecategories>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
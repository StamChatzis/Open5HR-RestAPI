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
    /// services.AddScoped<I<Dw_Admin_Create_Hr_AcountService>, Dw_Admin_Create_Hr_AcountService>();
    /// </summary>  
    public class Dw_Admin_Create_Hr_AcountService : PbServiceBase<Dw_Admin_Create_Hr_Acount>, IDw_Admin_Create_Hr_AcountService
    {
        public Dw_Admin_Create_Hr_AcountService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dw_Admin_Create_Hr_Acount>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Admin_Create_Hr_Acount>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
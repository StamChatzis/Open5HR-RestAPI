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
    public class Dw_Hr_ShowleavecategoriesService: IDw_Hr_ShowleavecategoriesService
    {

        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dw_Hr_ShowleavecategoriesService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dw_Hr_Showleavecategories>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Hr_Showleavecategories>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
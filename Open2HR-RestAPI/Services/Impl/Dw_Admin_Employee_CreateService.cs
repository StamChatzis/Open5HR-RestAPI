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
    /// services.AddScoped<I<Dw_Admin_Employee_CreateService>, Dw_Admin_Employee_CreateService>();
    /// </summary>  
    public class Dw_Admin_Employee_CreateService : IDw_Admin_Employee_CreateService
    {

        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dw_Admin_Employee_CreateService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dw_Admin_Employee_Create>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Admin_Employee_Create>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
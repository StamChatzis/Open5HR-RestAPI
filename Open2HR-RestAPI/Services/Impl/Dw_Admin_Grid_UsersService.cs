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
    /// services.AddScoped<I<Dw_Admin_Grid_UsersService>, Dw_Admin_Grid_UsersService>();
    /// </summary>  
    public class Dw_Admin_Grid_UsersService: IDw_Admin_Grid_UsersService
    {

        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dw_Admin_Grid_UsersService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dw_Admin_Grid_Users>> RetrieveAsync(double? an_id, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Admin_Grid_Users>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_id }, cancellationToken);

            return dataStore;
        }
    }  
}
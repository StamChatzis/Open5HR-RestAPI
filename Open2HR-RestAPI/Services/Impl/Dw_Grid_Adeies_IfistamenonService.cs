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
    /// services.AddScoped<I<Dw_Grid_Adeies_IfistamenonService>, Dw_Grid_Adeies_IfistamenonService>();
    /// </summary>  
    public class Dw_Grid_Adeies_IfistamenonService: IDw_Grid_Adeies_IfistamenonService
    {

        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dw_Grid_Adeies_IfistamenonService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dw_Grid_Adeies_Ifistamenon>> RetrieveAsync(double? an_ID, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Grid_Adeies_Ifistamenon>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_ID }, cancellationToken);

            return dataStore;
        }
    }  
}
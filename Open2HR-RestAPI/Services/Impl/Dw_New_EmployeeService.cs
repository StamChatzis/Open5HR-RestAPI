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
    /// services.AddScoped<I<Dw_New_EmployeeService>, Dw_New_EmployeeService>();
    /// </summary>  
    public class Dw_New_EmployeeService: IDw_New_EmployeeService
    {

        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dw_New_EmployeeService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dw_New_Employee>> RetrieveAsync(double? an_id, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_New_Employee>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {an_id }, cancellationToken);

            return dataStore;
        }
    }  
}
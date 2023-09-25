using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services.Impl
{
    public class Dddw_Supervisor_NamesService : PbServiceBase<Dddw_Supervisor_Names>, IDddw_Supervisor_NamesService
    {
        private readonly SampleDataContext _dataContext;
        private readonly IDw_SequenceService _sequenceService;

        public Dddw_Supervisor_NamesService(SampleDataContext dataContext, IDw_SequenceService sequenceService)
        {
            _dataContext = dataContext;
            _sequenceService = sequenceService;
        }

        public async Task<IDataStore<Dddw_Supervisor_Names>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dddw_Supervisor_Names>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
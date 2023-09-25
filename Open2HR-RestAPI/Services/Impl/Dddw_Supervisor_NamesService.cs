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
        public Dddw_Supervisor_NamesService(SampleDataContext dataContext) : base(dataContext)
        {
        }

        public async Task<IDataStore<Dddw_Supervisor_Names>> RetrieveAsync( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dddw_Supervisor_Names>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            return dataStore;
        }
    }  
}
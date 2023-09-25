using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;
using PowerScript.Bridge;

namespace Open2HRRestAPI.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<Dw_SequenceService>, Dw_SequenceService>();
    /// </summary>  
    public class Dw_SequenceService : IDw_SequenceService {

        private readonly SampleDataContext _dataContext;

        public Dw_SequenceService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
    }

        public async Task<int> GetNewId( CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Sequence>(_dataContext);

            await dataStore.RetrieveAsync(new object[] { }, cancellationToken);

            int lastId = 0;
            lastId = dataStore.GetItem<int>(dataStore.RowCount - 1, "id");

            int newId = 0;
            newId = lastId + 1;

            dataStore.SetItem(dataStore.RowCount - 1, "id", newId);

            dataStore.Update(true, PbResultStyle.Flags);

            return newId;
        }
    }  
}

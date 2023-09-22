using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_SequenceService : IPbServiceBase<Dw_Sequence>
    {
        Task<IDataStore<Dw_Sequence>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
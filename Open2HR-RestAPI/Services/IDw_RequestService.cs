using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_RequestService : IPbServiceBase<Dw_Request>
    {
        Task<IDataStore<Dw_Request>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Request_HistoryService
    {
        Task<IDataStore<Dw_Request_History>> RetrieveAsync(double? an_id, CancellationToken cancellationToken);
    }
}
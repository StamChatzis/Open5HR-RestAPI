using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDddw_Supervisor_NamesService : IPbServiceBase<Dddw_Supervisor_Names>
    {
        Task<IDataStore<Dddw_Supervisor_Names>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
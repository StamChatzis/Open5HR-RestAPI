using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_ProfileService : IPbServiceBase<Dw_Profile>
    {
        Task<IDataStore<Dw_Profile>> RetrieveAsync(double? an_id, CancellationToken cancellationToken);
    }
}
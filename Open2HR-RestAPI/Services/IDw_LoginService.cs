using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_LoginService : IPbServiceBase<Dw_Login>
    {
        Task<IDataStore<Dw_Login>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
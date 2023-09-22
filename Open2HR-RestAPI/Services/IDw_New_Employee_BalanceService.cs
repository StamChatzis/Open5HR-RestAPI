using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_New_Employee_BalanceService : IPbServiceBase<Dw_New_Employee_Balance>
    {
        Task<IDataStore<Dw_New_Employee_Balance>> RetrieveAsync(double? an_id, CancellationToken cancellationToken);
    }
}
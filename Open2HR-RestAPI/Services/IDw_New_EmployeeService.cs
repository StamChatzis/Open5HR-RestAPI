using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_New_EmployeeService : IPbServiceBase<Dw_New_Employee>
    {
        Task<IDataStore<Dw_New_Employee>> RetrieveAsync(double? an_id, CancellationToken cancellationToken);
    }
}
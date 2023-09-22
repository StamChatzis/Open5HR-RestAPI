using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Admin_Employee_CreateService : IPbServiceBase<Dw_Admin_Employee_Create>
    {
        Task<IDataStore<Dw_Admin_Employee_Create>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
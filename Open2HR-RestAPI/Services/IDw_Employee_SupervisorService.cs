using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Employee_SupervisorService
    {
        Task<IDataStore<Dw_Employee_Supervisor>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
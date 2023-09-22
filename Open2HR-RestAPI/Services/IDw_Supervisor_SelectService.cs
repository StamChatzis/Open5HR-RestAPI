using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Supervisor_SelectService
    {
        Task<IDataStore<Dw_Supervisor_Select>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
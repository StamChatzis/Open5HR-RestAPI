using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Employee_Sv_GridService
    {
        Task<IDataStore<Dw_Employee_Sv_Grid>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Hr_Employees_Wo_UsersService
    {
        Task<IDataStore<Dw_Hr_Employees_Wo_Users>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Admin_Employees_WithoutusersService
    {
        Task<IDataStore<Dw_Admin_Employees_Withoutusers>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Admin_Grid_UsersService
    {
        Task<IDataStore<Dw_Admin_Grid_Users>> RetrieveAsync(double? an_id, CancellationToken cancellationToken);
    }
}
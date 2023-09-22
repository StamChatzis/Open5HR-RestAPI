using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_AuthService
    {
        Task<IDataStore<Dw_Auth>> RetrieveAsync(string as_username,string as_password, CancellationToken cancellationToken);
    }
}
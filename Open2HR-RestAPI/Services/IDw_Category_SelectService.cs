using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Category_SelectService
    {
        Task<IDataStore<Dw_Category_Select>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
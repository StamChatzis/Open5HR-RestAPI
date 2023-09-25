using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Admin_Create_Hr_AcountService
    {
        Task<IDataStore<Dw_Admin_Create_Hr_Acount>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
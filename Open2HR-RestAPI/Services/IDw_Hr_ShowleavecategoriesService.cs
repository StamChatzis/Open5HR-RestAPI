using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Hr_ShowleavecategoriesService : IPbServiceBase<Dw_Hr_Showleavecategories>
    {
        Task<IDataStore<Dw_Hr_Showleavecategories>> RetrieveAsync( CancellationToken cancellationToken);
    }
}
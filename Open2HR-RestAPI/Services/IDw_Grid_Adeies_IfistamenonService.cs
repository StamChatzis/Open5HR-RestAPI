using System.Threading;
using System.Threading.Tasks;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services
{
    public interface IDw_Grid_Adeies_IfistamenonService
    {
        Task<IDataStore<Dw_Grid_Adeies_Ifistamenon>> RetrieveAsync(double? an_ID, CancellationToken cancellationToken);
    }
}
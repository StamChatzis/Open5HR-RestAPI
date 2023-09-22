using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;

namespace Open2HRRestAPI.Services.Impl
{
    public abstract class PbServiceBase<TModel> : IPbServiceBase<TModel>
    {
        protected readonly DataContext _dataContext;

        public PbServiceBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        public Task<int> UpdateAsync(IDataStore<TModel> dataStore, CancellationToken cancellationToken)
        {
            dataStore.DataContext = _dataContext;

            return dataStore.UpdateAsync(cancellationToken);
        }      
    }
}
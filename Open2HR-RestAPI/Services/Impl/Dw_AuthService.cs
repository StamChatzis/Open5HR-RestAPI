using System.Threading;
using System.Threading.Tasks;
using SnapObjects.Data;
using DWNet.Data;
using System;
using Open2HRRestAPI;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Services.Impl
{
    /// <summary>
    /// The service needs to be injected into the ConfigureServices method of the Startup class. The sample code is as follows:
    /// services.AddScoped<I<Dw_AuthService>, Dw_AuthService>();
    /// </summary>  
    public class Dw_AuthService : IDw_AuthService
    {
        private readonly DataContext _dataContext;
        public Dw_AuthService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IDataStore<Dw_Auth>> RetrieveAsync(string as_username,string as_password, CancellationToken cancellationToken)
        {
            var dataStore = new DataStore<Dw_Auth>(_dataContext);

            await dataStore.RetrieveAsync(new object[] {as_username, as_password }, cancellationToken);

            return dataStore;
        }
    }  
}
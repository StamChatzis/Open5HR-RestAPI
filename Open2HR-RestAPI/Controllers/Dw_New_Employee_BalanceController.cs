using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using DWNet.Data;
using Open2HRRestAPI.Services;
using System.Threading.Tasks;
using System.Threading;
using Open2HRRestAPI.Models;

namespace Open2HRRestAPI.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class Dw_New_Employee_BalanceController : ControllerBase
    {
        private readonly IDw_New_Employee_BalanceService _idw_new_employee_balanceservice;

        public Dw_New_Employee_BalanceController(IDw_New_Employee_BalanceService idw_new_employee_balanceservice)
        {
            _idw_new_employee_balanceservice = idw_new_employee_balanceservice;
        }
    
        //POST api/Dw_New_Employee_Balance/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_New_Employee_Balance> dataStore)
        {
            try
            {
                var result = await _idw_new_employee_balanceservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_New_Employee_Balance/Retrieve/{an_id}
        [HttpGet("{an_id}")]
        [ProducesResponseType(typeof(IDataStore<Dw_New_Employee_Balance>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_New_Employee_Balance>>> RetrieveAsync(double? an_id)
        {
            try
            {
                var result = await _idw_new_employee_balanceservice.RetrieveAsync(an_id, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
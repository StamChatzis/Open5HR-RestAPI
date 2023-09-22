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
	public class Dw_Employee_SupervisorController : ControllerBase
    {
        private readonly IDw_Employee_SupervisorService _idw_employee_supervisorservice;

        public Dw_Employee_SupervisorController(IDw_Employee_SupervisorService idw_employee_supervisorservice)
        {
            _idw_employee_supervisorservice = idw_employee_supervisorservice;
        }
    
        //POST api/Dw_Employee_Supervisor/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Employee_Supervisor> dataStore)
        {
            try
            {
                var result = await _idw_employee_supervisorservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Employee_Supervisor/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Employee_Supervisor>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Employee_Supervisor>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_employee_supervisorservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
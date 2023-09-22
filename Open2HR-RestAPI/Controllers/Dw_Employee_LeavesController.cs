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
	public class Dw_Employee_LeavesController : ControllerBase
    {
        private readonly IDw_Employee_LeavesService _idw_employee_leavesservice;

        public Dw_Employee_LeavesController(IDw_Employee_LeavesService idw_employee_leavesservice)
        {
            _idw_employee_leavesservice = idw_employee_leavesservice;
        }
    
        //GET api/Dw_Employee_Leaves/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Employee_Leaves>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Employee_Leaves>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_employee_leavesservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
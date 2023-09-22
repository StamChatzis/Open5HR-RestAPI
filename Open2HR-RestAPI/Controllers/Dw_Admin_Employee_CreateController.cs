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
	public class Dw_Admin_Employee_CreateController : ControllerBase
    {
        private readonly IDw_Admin_Employee_CreateService _idw_admin_employee_createservice;

        public Dw_Admin_Employee_CreateController(IDw_Admin_Employee_CreateService idw_admin_employee_createservice)
        {
            _idw_admin_employee_createservice = idw_admin_employee_createservice;
        }
    
        //POST api/Dw_Admin_Employee_Create/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Admin_Employee_Create> dataStore)
        {
            try
            {
                var result = await _idw_admin_employee_createservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Admin_Employee_Create/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Admin_Employee_Create>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Admin_Employee_Create>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_admin_employee_createservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
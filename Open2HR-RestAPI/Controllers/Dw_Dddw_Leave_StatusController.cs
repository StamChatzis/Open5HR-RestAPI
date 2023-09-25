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
	public class Dw_Dddw_Leave_StatusController : ControllerBase
    {
        private readonly IDw_Dddw_Leave_StatusService _idw_dddw_leave_statusservice;

        public Dw_Dddw_Leave_StatusController(IDw_Dddw_Leave_StatusService idw_dddw_leave_statusservice)
        {
            _idw_dddw_leave_statusservice = idw_dddw_leave_statusservice;
        }
    
        /*
        //POST api/Dw_Dddw_Leave_Status/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Dddw_Leave_Status> dataStore)
        {
            try
            {
                var result = await _idw_dddw_leave_statusservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dw_Dddw_Leave_Status/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Dddw_Leave_Status>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Dddw_Leave_Status>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_dddw_leave_statusservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
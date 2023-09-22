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
	public class Dw_Supervisor_LeavesController : ControllerBase
    {
        private readonly IDw_Supervisor_LeavesService _idw_supervisor_leavesservice;

        public Dw_Supervisor_LeavesController(IDw_Supervisor_LeavesService idw_supervisor_leavesservice)
        {
            _idw_supervisor_leavesservice = idw_supervisor_leavesservice;
        }
    
        //GET api/Dw_Supervisor_Leaves/Retrieve/{an_ID}
        [HttpGet("{an_ID}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Supervisor_Leaves>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Supervisor_Leaves>>> RetrieveAsync(double? an_ID)
        {
            try
            {
                var result = await _idw_supervisor_leavesservice.RetrieveAsync(an_ID, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
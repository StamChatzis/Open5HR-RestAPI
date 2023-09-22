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
	public class Dw_SupervisorController : ControllerBase
    {
        private readonly IDw_SupervisorService _idw_supervisorservice;

        public Dw_SupervisorController(IDw_SupervisorService idw_supervisorservice)
        {
            _idw_supervisorservice = idw_supervisorservice;
        }
    
        //GET api/Dw_Supervisor/Retrieve/{an_id}
        [HttpGet("{an_id}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Supervisor>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Supervisor>>> RetrieveAsync(double? an_id)
        {
            try
            {
                var result = await _idw_supervisorservice.RetrieveAsync(an_id, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
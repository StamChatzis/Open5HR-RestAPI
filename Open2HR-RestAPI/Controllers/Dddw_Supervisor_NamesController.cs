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
	public class Dddw_Supervisor_NamesController : ControllerBase
    {
        private readonly IDddw_Supervisor_NamesService _idddw_supervisor_namesservice;

        public Dddw_Supervisor_NamesController(IDddw_Supervisor_NamesService idddw_supervisor_namesservice)
        {
            _idddw_supervisor_namesservice = idddw_supervisor_namesservice;
        }
    
        /*
        //POST api/Dddw_Supervisor_Names/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dddw_Supervisor_Names> dataStore)
        {
            try
            {
                var result = await _idddw_supervisor_namesservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dddw_Supervisor_Names/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dddw_Supervisor_Names>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dddw_Supervisor_Names>>> RetrieveAsync()
        {
            try
            {
                var result = await _idddw_supervisor_namesservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
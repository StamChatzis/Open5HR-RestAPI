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
	public class Dw_RequestController : ControllerBase
    {
        private readonly IDw_RequestService _idw_requestservice;

        public Dw_RequestController(IDw_RequestService idw_requestservice)
        {
            _idw_requestservice = idw_requestservice;
        }
    
        /*
        //POST api/Dw_Request/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Request> dataStore)
        {
            try
            {
                var result = await _idw_requestservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dw_Request/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Request>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Request>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_requestservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
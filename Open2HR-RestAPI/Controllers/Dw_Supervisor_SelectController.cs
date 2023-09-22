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
	public class Dw_Supervisor_SelectController : ControllerBase
    {
        private readonly IDw_Supervisor_SelectService _idw_supervisor_selectservice;

        public Dw_Supervisor_SelectController(IDw_Supervisor_SelectService idw_supervisor_selectservice)
        {
            _idw_supervisor_selectservice = idw_supervisor_selectservice;
        }
    
        //GET api/Dw_Supervisor_Select/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Supervisor_Select>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Supervisor_Select>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_supervisor_selectservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
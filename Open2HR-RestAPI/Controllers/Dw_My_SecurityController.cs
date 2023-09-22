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
	public class Dw_My_SecurityController : ControllerBase
    {
        private readonly IDw_My_SecurityService _idw_my_securityservice;

        public Dw_My_SecurityController(IDw_My_SecurityService idw_my_securityservice)
        {
            _idw_my_securityservice = idw_my_securityservice;
        }
    
        //GET api/Dw_My_Security/Retrieve/{an_id}
        [HttpGet("{an_id}")]
        [ProducesResponseType(typeof(IDataStore<Dw_My_Security>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_My_Security>>> RetrieveAsync(double? an_id)
        {
            try
            {
                var result = await _idw_my_securityservice.RetrieveAsync(an_id, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
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
	public class Dw_AuthController : ControllerBase
    {
        private readonly IDw_AuthService _idw_authservice;

        public Dw_AuthController(IDw_AuthService idw_authservice)
        {
            _idw_authservice = idw_authservice;
        }
    
        //GET api/Dw_Auth/Retrieve/{as_username}/{as_password}
        [HttpGet("{as_username}/{as_password}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Auth>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Auth>>> RetrieveAsync(string as_username, string as_password)
        {
            try
            {
                var result = await _idw_authservice.RetrieveAsync(as_username, as_password, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
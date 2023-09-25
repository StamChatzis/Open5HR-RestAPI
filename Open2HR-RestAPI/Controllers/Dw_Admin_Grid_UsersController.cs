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
	public class Dw_Admin_Grid_UsersController : ControllerBase
    {
        private readonly IDw_Admin_Grid_UsersService _idw_admin_grid_usersservice;

        public Dw_Admin_Grid_UsersController(IDw_Admin_Grid_UsersService idw_admin_grid_usersservice)
        {
            _idw_admin_grid_usersservice = idw_admin_grid_usersservice;
        }
    
        /*
        //POST api/Dw_Admin_Grid_Users/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Admin_Grid_Users> dataStore)
        {
            try
            {
                var result = await _idw_admin_grid_usersservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dw_Admin_Grid_Users/Retrieve/{an_id}
        [HttpGet("{an_id}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Admin_Grid_Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Admin_Grid_Users>>> RetrieveAsync(double? an_id)
        {
            try
            {
                var result = await _idw_admin_grid_usersservice.RetrieveAsync(an_id, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
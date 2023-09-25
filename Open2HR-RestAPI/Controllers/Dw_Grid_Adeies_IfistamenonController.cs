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
	public class Dw_Grid_Adeies_IfistamenonController : ControllerBase
    {
        private readonly IDw_Grid_Adeies_IfistamenonService _idw_grid_adeies_ifistamenonservice;

        public Dw_Grid_Adeies_IfistamenonController(IDw_Grid_Adeies_IfistamenonService idw_grid_adeies_ifistamenonservice)
        {
            _idw_grid_adeies_ifistamenonservice = idw_grid_adeies_ifistamenonservice;
        }
    
        /*
        //POST api/Dw_Grid_Adeies_Ifistamenon/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Grid_Adeies_Ifistamenon> dataStore)
        {
            try
            {
                var result = await _idw_grid_adeies_ifistamenonservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dw_Grid_Adeies_Ifistamenon/Retrieve/{an_ID}
        [HttpGet("{an_ID}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Grid_Adeies_Ifistamenon>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Grid_Adeies_Ifistamenon>>> RetrieveAsync(double? an_ID)
        {
            try
            {
                var result = await _idw_grid_adeies_ifistamenonservice.RetrieveAsync(an_ID, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
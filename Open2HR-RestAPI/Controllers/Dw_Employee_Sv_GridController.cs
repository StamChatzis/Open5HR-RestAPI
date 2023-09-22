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
	public class Dw_Employee_Sv_GridController : ControllerBase
    {
        private readonly IDw_Employee_Sv_GridService _idw_employee_sv_gridservice;

        public Dw_Employee_Sv_GridController(IDw_Employee_Sv_GridService idw_employee_sv_gridservice)
        {
            _idw_employee_sv_gridservice = idw_employee_sv_gridservice;
        }
    
        //POST api/Dw_Employee_Sv_Grid/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Employee_Sv_Grid> dataStore)
        {
            try
            {
                var result = await _idw_employee_sv_gridservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Employee_Sv_Grid/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Employee_Sv_Grid>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Employee_Sv_Grid>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_employee_sv_gridservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
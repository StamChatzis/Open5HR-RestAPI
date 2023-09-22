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
	public class Dw_Admin_Grid_EmployeesController : ControllerBase
    {
        private readonly IDw_Admin_Grid_EmployeesService _idw_admin_grid_employeesservice;

        public Dw_Admin_Grid_EmployeesController(IDw_Admin_Grid_EmployeesService idw_admin_grid_employeesservice)
        {
            _idw_admin_grid_employeesservice = idw_admin_grid_employeesservice;
        }
    
        //GET api/Dw_Admin_Grid_Employees/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Admin_Grid_Employees>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Admin_Grid_Employees>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_admin_grid_employeesservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
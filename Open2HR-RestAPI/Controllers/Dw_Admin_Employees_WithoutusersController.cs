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
	public class Dw_Admin_Employees_WithoutusersController : ControllerBase
    {
        private readonly IDw_Admin_Employees_WithoutusersService _idw_admin_employees_withoutusersservice;

        public Dw_Admin_Employees_WithoutusersController(IDw_Admin_Employees_WithoutusersService idw_admin_employees_withoutusersservice)
        {
            _idw_admin_employees_withoutusersservice = idw_admin_employees_withoutusersservice;
        }
    
        //GET api/Dw_Admin_Employees_Withoutusers/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Admin_Employees_Withoutusers>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Admin_Employees_Withoutusers>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_admin_employees_withoutusersservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
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
	public class Dw_Hr_Employees_Wo_UsersController : ControllerBase
    {
        private readonly IDw_Hr_Employees_Wo_UsersService _idw_hr_employees_wo_usersservice;

        public Dw_Hr_Employees_Wo_UsersController(IDw_Hr_Employees_Wo_UsersService idw_hr_employees_wo_usersservice)
        {
            _idw_hr_employees_wo_usersservice = idw_hr_employees_wo_usersservice;
        }
    
        //GET api/Dw_Hr_Employees_Wo_Users/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Hr_Employees_Wo_Users>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Hr_Employees_Wo_Users>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_hr_employees_wo_usersservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
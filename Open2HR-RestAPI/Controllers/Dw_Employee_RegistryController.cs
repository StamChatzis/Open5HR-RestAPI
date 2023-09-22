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
	public class Dw_Employee_RegistryController : ControllerBase
    {
        private readonly IDw_Employee_RegistryService _idw_employee_registryservice;

        public Dw_Employee_RegistryController(IDw_Employee_RegistryService idw_employee_registryservice)
        {
            _idw_employee_registryservice = idw_employee_registryservice;
        }
    
        //GET api/Dw_Employee_Registry/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Employee_Registry>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Employee_Registry>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_employee_registryservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
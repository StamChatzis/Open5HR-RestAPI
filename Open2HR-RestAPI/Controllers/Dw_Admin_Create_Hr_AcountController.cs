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
	public class Dw_Admin_Create_Hr_AcountController : ControllerBase
    {
        private readonly IDw_Admin_Create_Hr_AcountService _idw_admin_create_hr_acountservice;

        public Dw_Admin_Create_Hr_AcountController(IDw_Admin_Create_Hr_AcountService idw_admin_create_hr_acountservice)
        {
            _idw_admin_create_hr_acountservice = idw_admin_create_hr_acountservice;
        }
    
        //POST api/Dw_Admin_Create_Hr_Acount/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Admin_Create_Hr_Acount> dataStore)
        {
            try
            {
                var result = await _idw_admin_create_hr_acountservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Admin_Create_Hr_Acount/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Admin_Create_Hr_Acount>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Admin_Create_Hr_Acount>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_admin_create_hr_acountservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
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
	public class Dw_Hr_ShowleavecategoriesController : ControllerBase
    {
        private readonly IDw_Hr_ShowleavecategoriesService _idw_hr_showleavecategoriesservice;

        public Dw_Hr_ShowleavecategoriesController(IDw_Hr_ShowleavecategoriesService idw_hr_showleavecategoriesservice)
        {
            _idw_hr_showleavecategoriesservice = idw_hr_showleavecategoriesservice;
        }
    
        /*
        //POST api/Dw_Hr_Showleavecategories/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Hr_Showleavecategories> dataStore)
        {
            try
            {
                var result = await _idw_hr_showleavecategoriesservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }*/

        //GET api/Dw_Hr_Showleavecategories/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Hr_Showleavecategories>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Hr_Showleavecategories>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_hr_showleavecategoriesservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
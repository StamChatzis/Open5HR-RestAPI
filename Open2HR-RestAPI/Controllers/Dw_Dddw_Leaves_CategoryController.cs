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
	public class Dw_Dddw_Leaves_CategoryController : ControllerBase
    {
        private readonly IDw_Dddw_Leaves_CategoryService _idw_dddw_leaves_categoryservice;

        public Dw_Dddw_Leaves_CategoryController(IDw_Dddw_Leaves_CategoryService idw_dddw_leaves_categoryservice)
        {
            _idw_dddw_leaves_categoryservice = idw_dddw_leaves_categoryservice;
        }
    
        //POST api/Dw_Dddw_Leaves_Category/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Dddw_Leaves_Category> dataStore)
        {
            try
            {
                var result = await _idw_dddw_leaves_categoryservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Dddw_Leaves_Category/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Dddw_Leaves_Category>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Dddw_Leaves_Category>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_dddw_leaves_categoryservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
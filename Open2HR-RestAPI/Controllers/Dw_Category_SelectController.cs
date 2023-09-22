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
	public class Dw_Category_SelectController : ControllerBase
    {
        private readonly IDw_Category_SelectService _idw_category_selectservice;

        public Dw_Category_SelectController(IDw_Category_SelectService idw_category_selectservice)
        {
            _idw_category_selectservice = idw_category_selectservice;
        }
    
        //GET api/Dw_Category_Select/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Category_Select>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Category_Select>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_category_selectservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
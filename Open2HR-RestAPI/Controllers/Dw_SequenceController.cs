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
	public class Dw_SequenceController : ControllerBase
    {
        private readonly IDw_SequenceService _idw_sequenceservice;

        public Dw_SequenceController(IDw_SequenceService idw_sequenceservice)
        {
            _idw_sequenceservice = idw_sequenceservice;
        }
    
        //POST api/Dw_Sequence/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Dw_Sequence> dataStore)
        {
            try
            {
                var result = await _idw_sequenceservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Dw_Sequence/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IDataStore<Dw_Sequence>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Sequence>>> RetrieveAsync()
        {
            try
            {
                var result = await _idw_sequenceservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
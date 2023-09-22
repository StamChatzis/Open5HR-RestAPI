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
	public class Dw_Request_HistoryController : ControllerBase
    {
        private readonly IDw_Request_HistoryService _idw_request_historyservice;

        public Dw_Request_HistoryController(IDw_Request_HistoryService idw_request_historyservice)
        {
            _idw_request_historyservice = idw_request_historyservice;
        }
    
        //GET api/Dw_Request_History/Retrieve/{an_id}
        [HttpGet("{an_id}")]
        [ProducesResponseType(typeof(IDataStore<Dw_Request_History>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Dw_Request_History>>> RetrieveAsync(double? an_id)
        {
            try
            {
                var result = await _idw_request_historyservice.RetrieveAsync(an_id, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}
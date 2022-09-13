using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceHistoryController : ControllerBase
    {
        private readonly IPerformanceHistory _performanceHistory;
        public PerformanceHistoryController(IPerformanceHistory performanceHistory)
        {
            _performanceHistory = performanceHistory;
        }
        [HttpGet]
        public IActionResult GetPerformanceHistory()
        {
            return Ok(_performanceHistory.performanceHistory());
        }

    }
}

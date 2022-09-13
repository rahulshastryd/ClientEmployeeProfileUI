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
    public class CareerHistoryController : ControllerBase
    {
        private readonly ICareerHistory _careerHistory;
        public CareerHistoryController(ICareerHistory careerHistory)
        {
            _careerHistory = careerHistory;
        }

        [HttpGet]
        public IActionResult GetCareerHistory()
        {
            return Ok(_careerHistory.careerHistory());
        }
    }
}

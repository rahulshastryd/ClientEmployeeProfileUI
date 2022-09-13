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
    public class QPRatingController : ControllerBase
    {
        private readonly IQualificationAndPerformanceRating _rating;
        public QPRatingController(IQualificationAndPerformanceRating rating)
        {
            _rating = rating;
        }
        [HttpGet]
        public IActionResult QPRating()
        {
            return Ok(_rating.qpRating());
        }
    }
}

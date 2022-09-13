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
    public class PreviousEmploymentController : ControllerBase
    {
        private readonly IPreviousEmployment _previousEmployment;

        public PreviousEmploymentController(IPreviousEmployment previousEmployment)
        {
            _previousEmployment = previousEmployment;
        }
        [HttpGet]
        public IActionResult GetPreviousEmployment()
        {
            return Ok(_previousEmployment.preiousEmployment());
        }
    }
}

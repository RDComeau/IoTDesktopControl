using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTDesktopControl.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        public TestApiController()
        {

        }

        [HttpGet]
        public ActionResult<string> GetTest()
        {
            return StatusCode(200, "This works!");
        }
    }
}

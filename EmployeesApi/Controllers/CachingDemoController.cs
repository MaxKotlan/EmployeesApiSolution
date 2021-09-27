using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class CachingDemoController : ControllerBase
    {

        [HttpGet("/cached")]
        [ResponseCache(Location = ResponseCacheLocation.Any,Duration = 5)]
        public async Task<ActionResult> GetSomeSlowStuff()
        {
            await Task.Delay(3000);
            return Ok(new { data = "Your Stuff Here.", when=DateTime.Now });
        }

        [HttpGet("/cached2")]
        public async Task<ActionResult> ServerObjectCaching()
        {
            return Ok(); // TODO: Write some code here.
        }
    }
}

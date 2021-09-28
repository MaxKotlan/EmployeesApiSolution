using HiringApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringApi.Controllers
{
    public class HiringRequestController : ControllerBase
    {
        [HttpPost("hiring-requests")]
        public async Task<ActionResult> AddHiringRequest([FromBody] PostHiringRequest request)
        {
           // Validate - if bad, return a 400.
           if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Save it (for us, to a database) 
            // return a reponse
            //   201 Created
            //   Location with the url of the new thing.
            //   Send them a copy of it.
            await Task.Delay(3000);
            return Ok(request);
        }
    }
}

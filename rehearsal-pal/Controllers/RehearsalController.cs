using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rehearsal_pal.Controllers
{
    [Route("api/[controller]")]
    public class RehearsalController : Controller
    {      
        [HttpGet("rehearsal")]
        public async Task<bool> GetRehearsal()
        {          
          return true;
        }
    }
}

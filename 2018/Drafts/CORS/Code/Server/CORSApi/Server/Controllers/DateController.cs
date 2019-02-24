using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {
        [HttpGet]
        public ActionResult<DateTime> Get()
        {
            return DateTime.Now;
        }

        [HttpPut]
        public ActionResult<DateTime> Update(DateTime dateTime)
        {
            return DateTime.Now;
        }

    }
}

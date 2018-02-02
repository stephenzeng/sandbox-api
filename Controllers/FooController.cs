using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sandbox_api.Controllers
{
    [Route("api/[controller]")]
    public class FooController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "0.0.5";
        }
    }
}

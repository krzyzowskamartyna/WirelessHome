using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WirelessHome.Controllers
{
    [Route("/api/[Controller]")]
    public class testController: Controller
    {
        [HttpGet("/api/values")]
        public IEnumerable<string> Get()
        {

            return new string[] { "a", "b", "c", "d" };
        }
    }
}

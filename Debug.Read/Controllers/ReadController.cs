using Microsoft.AspNetCore.Mvc;
using ReadApi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Debug.Read.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "hejsan";
        }
    }
}

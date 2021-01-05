using Microsoft.AspNetCore.Mvc;
using ReadApi.Data.Database;
using ReadApi.Data.Repository;
using ReadApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ReadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadController : Controller
    {
        private readonly IReadRepository repo;

        public ReadController(IReadRepository context)
        {
            repo = context;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Message>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(repo.GetAllMessages());
        }
    }
}

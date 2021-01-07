using Database.Models;
using Database.Repository;
using Microsoft.AspNetCore.Mvc;
using ReadApi.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WriteController : Controller
    {
        private readonly IWriteRepository repo;

        public WriteController(IWriteRepository context)
        {
            repo = context;
        }

        [HttpPost]
        public List<Message> AddMessage(Message msg)
        {
            List<Message> newmsg = repo.AddMessage(msg);
            return newmsg;
        }
    }
}

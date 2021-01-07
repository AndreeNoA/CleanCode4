using Database.Models;
using Database.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateController : Controller
    {
        private readonly IUpdateRepository repo;
        public UpdateController(IUpdateRepository context)
        {
            repo = context;
        }
        [HttpPost]
        public Message UpdateMessage(Guid msg, string newText)
        {
            Message updatedMessage = repo.UpdateMessage(msg, newText);
            return updatedMessage;
        }
    }
}

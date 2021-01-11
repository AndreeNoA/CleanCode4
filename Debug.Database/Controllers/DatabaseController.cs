using Debug.Database.Context;
using Debug.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Debug.Database.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController
    {
        private readonly ApplicationDbContext _db;
    
        public DatabaseController(ApplicationDbContext db)
        {
            _db = db;
        }
    
        [HttpGet]
        [Route("db")]
        public async Task<IActionResult> Get()
        {
            var notes = await _db.Messages.ToListAsync();
    
            return new JsonResult(notes);
        }
        [HttpDelete("{id}")]
        [Route("db")]
        public async Task<IActionResult> DeleteById(Guid id)
        {
            return new OkObjectResult("Done");
        }
        [HttpPost]
        [Route("db")]
        public IActionResult SaveToDb(Message message)
        {
            return new OkObjectResult("Done");
        }
        [HttpPost("{id}")]
        [Route("db")]
        public async Task<IActionResult> UpdateBug(Guid id)
        {
            return new OkObjectResult("Done");
        }
    }

}

using Debug.Read.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Debug.Read.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ReadController : ControllerBase
    {
        HttpClient client = new HttpClient();

        public ReadController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dbResponse = await client.GetAsync("http://debug.database/database/db");
            var dbResponseAsString = await dbResponse.Content.ReadAsStringAsync();
            List<Message> messages = JsonConvert.DeserializeObject<List<Message>>(dbResponseAsString);
            return Ok(messages);
        }
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var notes = await _db.Messages.ToListAsync();
        //
        //    return new JsonResult(notes);
        //}
        //
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(Guid id)
        //{
        //    var note = await _db.Messages.FirstOrDefaultAsync(n => n.Id == id);
        //
        //    return new JsonResult(note);
        //}
    }

}

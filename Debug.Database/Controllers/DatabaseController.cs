﻿using Debug.Database.Context;
using Debug.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Debug.Database.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class DatabaseController : ControllerBase
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

        [HttpPost]
        [Route("db/create")]
        public IActionResult SaveToDb([FromBody]Message msg)
        {
            _db.Add(msg);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("db/update")]
        public async Task<IActionResult> UpdateBug(string id, string updatedText)
        {
            var guidId = Guid.Parse(id);

            var msg = _db.Messages.Where(x => x.Id == guidId).FirstOrDefault();
            msg.Text = updatedText;
            _db.SaveChanges();

            return Ok();
        }
    }

}

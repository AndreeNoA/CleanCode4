using Debug.Read.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Debug.Read.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NotesController
    {
        private readonly ApplicationDbContext _db;

        public NotesController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var notes = await _db.Messages.ToListAsync();

            return new JsonResult(notes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var note = await _db.Messages.FirstOrDefaultAsync(n => n.Id == id);

            return new JsonResult(note);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Message note)
        {
            _db.Messages.Add(note);
            await _db.SaveChangesAsync();

            return new JsonResult(note.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, Message note)
        {
            var existingNote = await _db.Messages.FirstOrDefaultAsync(n => n.Id == id);
            existingNote.Text = note.Text;
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var note = await _db.Messages.FirstOrDefaultAsync(n => n.Id == id);
            _db.Remove(note);
            var success = (await _db.SaveChangesAsync()) > 0;

            return new JsonResult(success);
        }
    }

}

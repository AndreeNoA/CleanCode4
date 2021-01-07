using Database.Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class WriteRepository : IWriteRepository
    {
        List<Message> msg;
        private readonly ReadContext _context;

        public WriteRepository(ReadContext context)
        {
            _context = context;
            msg = _context.Messages.ToList();
        }
        public List<Message> AddMessage(Message mes)
        {
            msg.Add(new Message { Author = mes.Author, Text = mes.Text, Id = mes.Id });
            return msg;
        }
    }
}

using Database.Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public class UpdateRepository : IUpdateRepository
    {
        List<Message> msg;
        private readonly ReadContext _context;

        public UpdateRepository(ReadContext context)
        {
            _context = context;
            msg = _context.Messages.ToList();
        }
        public Message UpdateMessage(Guid id, string newText)
        {
            var pickedmsg = msg.Where(x => x.Id == id).FirstOrDefault();
            pickedmsg.Text = newText;

            return pickedmsg;
        }
    }
}

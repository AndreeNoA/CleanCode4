using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public interface IWriteRepository
    {
        List<Message> AddMessage(Message msg);
    }
}

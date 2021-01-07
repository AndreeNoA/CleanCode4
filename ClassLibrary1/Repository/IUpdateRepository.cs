using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repository
{
    public interface IUpdateRepository
    {
        Message UpdateMessage(Guid msg, string newText);
    }
}

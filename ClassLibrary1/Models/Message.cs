using System;

namespace Database.Models
{
    public partial class Message
    {
        public Guid Id { get; set; }
        public string Text {get; set;}
        public string Author { get; set; }
    }
}

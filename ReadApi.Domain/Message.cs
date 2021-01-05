using System;

namespace ReadApi.Domain
{
    public partial class Message
    {
        public Guid Id { get; set; }
        public string Text {get; set;}
        public string Author { get; set; }
    }
}

using System;

namespace DLL.Models
{
    public class Message
    {
        public int Id { get; set; } // for db storage
        public string Name { get; set; } // sender of msg
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}


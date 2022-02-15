using System.Collections.Generic;

namespace DLL.Models
{
    public class Chat
    {
        public Chat()
        {
            Messages = new List<Message>();
            Users = new List<ChatUser>();
        }

        public int Id { get; set; } // to store in db
        public string Name { get; set; }
        public ChatType Type { get; set; }
        public ICollection<Message> Messages { get; set; } // collection of messages
        public ICollection<ChatUser> Users { get; set; }
    }

}

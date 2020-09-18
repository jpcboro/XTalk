using System;
namespace XTalk.Core.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int ChatExchangeID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string TextMessage { get; set; }

    }
}

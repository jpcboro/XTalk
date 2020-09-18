using System;
using System.Threading.Tasks;
using XTalk.Core.Models;

namespace XTalk.Core.Interfaces
{
    public interface IWebService
    {
        Task<User> LoginWithUserNameAndPassword(string username, string password);
        Task<User> Register(User user);
        Task<User[]> GetContacts(int userID);
        Task<User> AddContact(int userID, string username);
        Task<ChatExchange[]> GetChatExchanges(int userID);
        Task<Message[]> GetMessages(int chatExchangeID);
        Task<Message> SendMessage(Message message);

    }
}

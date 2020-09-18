using System.Threading.Tasks;
using XTalk.Core.Interfaces;
using XTalk.Core.Models;

namespace XTalk.Core.Services
{
    public class TempWebService : IWebService
    {
        public  int SleepDuration { get; set; }

        public TempWebService()
        {
            SleepDuration = 3;
        }

        Task Sleep()
        {
            var sleepDelay = Task.Delay(SleepDuration);

            return sleepDelay;
        }

       

        public async Task<User> LoginWithUserNameAndPassword(string username, string password)
        {
            await Sleep();

            var newUser = new User()
            {
                UserID = 1,
                Username = username
            };

            return newUser;
        }

        public async Task<User> Register(User user)
        {
            await Sleep();
            return user;
        }

        public async Task<User[]> GetContacts(int userID)
        {
            await Sleep();

            var contacts = new[]
            {
                new User()
                {
                    UserID = 2,
                    Username = "TestName2"
                },
                new User()
                {
                    UserID = 3,
                    Username = "Nameless3"
                } 
            };

            return contacts;
        }

        public async Task<User> AddContact(int userID, string username)
        {
            await Sleep();
            
            return  new User()
            {
                UserID = 5,
                Username = "Nameless5"
            };
            
        }

        public async Task<ChatExchange[]> GetChatExchanges(int userID)
        {
            await Sleep();

            return new[]
            {
                new ChatExchange()
                {
                    ChatExchangeID = 1,
                    UserID = 2
                },
                new ChatExchange()
                {
                    ChatExchangeID = 1,
                    UserID = 3
                },
            };
        }

        public async Task<Message[]> GetMessages(int chatExchangeID)
        {
            await Sleep();
            return new[]
            {
                new Message()
                {
                    MessageID = 1,
                    ChatExchangeID = chatExchangeID,
                    UserID = 2,
                    TextMessage = "Test Message"
                },
            };
        }

        public async Task<Message> SendMessage(Message message)
        {
            await Sleep();

            return message;
        }
    }
}
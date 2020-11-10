using NextSoftPrism.Services.Interfaces;

namespace NextSoftPrism.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}

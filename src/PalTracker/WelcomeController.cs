using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{

  public class WelcomeMessage
    {
        public string Message { get; }

        public WelcomeMessage(string message)
        {
            Message = message;
        }
    }

    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        private readonly PalTracker.WelcomeMessage _message;
        [HttpGet]
        public string SayHello() => _message.Message;
        public WelcomeController(PalTracker.WelcomeMessage message){
            _message=message;
        }
    }
}
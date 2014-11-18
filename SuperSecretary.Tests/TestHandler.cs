using SuperSecretary.Handlers;

namespace SuperSecretary.Tests
{
    public class TestHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "Test Handler";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            return new HandlerResult() { Value = "Test Value" };
        }
    }
}

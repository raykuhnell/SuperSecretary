
namespace SuperSecretary.Handlers
{
    public interface IHandler
    {
        string Name { get; }
        HandlerResult Do(string fileName, HandlerOptions options);
    }
}

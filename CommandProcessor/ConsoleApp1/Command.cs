
namespace CommandProcessor
{
    /// <summary>
    /// abstract command
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Execute(string param);
    }
}

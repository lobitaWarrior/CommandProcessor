

/// <summary>
/// abstract receiver action
/// </summary>
namespace CommandProcessor
{
    public abstract class Action
    {
        protected string command;
        protected Directory dir;
        public abstract void Execute();
        public abstract void Execute(string param);
    }
}

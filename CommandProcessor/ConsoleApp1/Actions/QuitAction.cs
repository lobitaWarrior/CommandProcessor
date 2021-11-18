using System;

namespace CommandProcessor.Actions
{
    /// <summary>
    /// receiver quit
    /// </summary>
    public class QuitAction : Action
    {
        public QuitAction()
        {

        }
        public override void Execute()
        {
            Console.WriteLine("exit application");
            Environment.Exit(0);
        }

        public override void Execute(string param)
        {
            throw new NotImplementedException();
        }
    }
}

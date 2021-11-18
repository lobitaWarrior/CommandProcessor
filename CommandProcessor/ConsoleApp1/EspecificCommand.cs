using System;
using System.Collections.Generic;
using System.Text;

namespace CommandProcessor
{
    /// <summary>
    /// concrete command
    /// </summary>
    public class EspecificCommand : Command
    {
        Action action;
        public EspecificCommand(Action action)
        {
            this.action = action;
        }
        public override void Execute()
        {
            action.Execute();
        }
        public override void Execute(string param)
        {
            action.Execute(param);

        }
    }
}

using System;

namespace CommandProcessor.Actions
{
    public class PwdAction : Action
    {
        public PwdAction(Directory _dir)
        {
            this.dir = _dir;
        }
        public override void Execute()
        {
            Console.WriteLine(dir.GetCurrentDirectory());
        }

        public override void Execute(string param)
        {
            throw new NotImplementedException();
        }
    }
}

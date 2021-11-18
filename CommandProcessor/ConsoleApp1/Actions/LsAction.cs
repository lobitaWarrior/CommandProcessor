using System;


namespace CommandProcessor.Actions
{
    public class LsAction : Action
    {
        public LsAction(Directory _dir)
        {
            this.dir = _dir;
        }
        public override void Execute()
        {
            dir.GetDirectories();
            dir.GetFiles();
        }

        public override void Execute(string param)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace CommandProcessor.Actions
{
    public class MkdAction : Action
    {
        public MkdAction(Directory _dir)
        {
            this.dir = _dir;
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override void Execute(string param)
        {
            try
            {
                if (param != "")
                    dir.CreateDirectory(param);
                else
                    throw new Exception("Missing parameter dirName");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

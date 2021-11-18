
using System;

namespace CommandProcessor.Actions
{
    public class CdAction:Action
    {
        public CdAction(Directory _dir)
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
                    dir = dir.ChangeDirectory(param);
                else
                    throw new Exception("Missing parameter dirName");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Directory GetNewDirectory()
        {
            return dir;
        }
    }
}

using System;


namespace CommandProcessor.Actions
{
    public class TouchAction:Action
    {
        public TouchAction(Directory _dir)
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
                    dir.CreateFile(param);
                else
                    throw new Exception("Missing parameter fileName");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

namespace CommandProcessor
{
    public class File
    {
        private string fileName;

        public string GetFile()
        {
            return this.fileName;
        }

        public static File CreateFile(string fileName)
        {
            try
            {
                File newfile = new File();
                newfile.fileName = fileName;
                return newfile;

            }
            catch
            {
                throw new Exception("cannot create new file");
            }

        }
    }
}

using System;
using System.Collections.Generic;


namespace CommandProcessor
{
    public class Directory
    {

        private string currentDirectory;
        private List<File> files = new List<File>();
        private List<Directory> directories = new List<Directory>();

        public Directory(string route)
        {
            currentDirectory = route;
        }
        public string GetCurrentDirectory()
        {
            return currentDirectory;
        }

        public void GetFiles()
        {
            foreach (File f in files)
            {
                Console.WriteLine(f.GetFile());
            }
        }
        public void GetDirectories()
        {
            foreach (Directory d in directories)
            {
                Console.WriteLine(d.currentDirectory);
            }
        }
        public void CreateDirectory(string dirName)
        {
            try
            {
                Directory newDir = new Directory(dirName);
                if (directories.Exists(d => d.currentDirectory == dirName))
                    throw new Exception("Directory already exists");
                else
                    directories.Add(newDir);
            }
            catch
            {
                throw new Exception("cannot create new directory");
            }
        }

        public Directory ChangeDirectory(string dirName)
        {
            try
            {
                //GUARDARSE EL HISTORICO DE DIRECTORIOS PARA PODER VOLVER
                if (dirName == "..")
                    return directories.Find(d => d.currentDirectory == "root");
                else
                    return directories.Find(d => d.currentDirectory == dirName);
            }
            catch
            {
                throw new Exception("Directory not found");
            }
        }

        public void CreateFile(string fileName)
        {
            files.Add(File.CreateFile(fileName));
        }
    }
}

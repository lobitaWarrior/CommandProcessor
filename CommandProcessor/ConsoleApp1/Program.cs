using System;
using CommandProcessor;
using CommandProcessor.Actions;

namespace Solution
{
    class Solution
    {
     
        static void Main(string[] args)
        {
            
            Directory currentDirectory= new Directory("root");
            readInput readInput;

            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
                readInput = new readInput(Console.ReadLine(), currentDirectory);
                currentDirectory = readInput.Read();
            }


        }

    }

    /// <summary>
    /// invoker
    /// </summary>
    public class readInput
    {
        string _command;
        string param;
        Directory dir;
        public readInput(string input, Directory dir)
        {
            string[] subs = input.Split(" ");
            this._command = subs[0];
            if (subs.Length > 1)
                param = subs[1];
            else
                param = "";
            
            this.dir = dir;
        }

        public Directory Read()
        {
            Command command=null;

            switch (_command.ToLower())
            {
                case "quit":
                    command = new EspecificCommand(new QuitAction());
                    command.Execute();
                    break;
                case "pwd":
                    command = new EspecificCommand(new PwdAction(dir));
                    command.Execute();
                    break;
                case "ls":
                    command = new EspecificCommand(new LsAction(dir));
                    command.Execute();
                    break;
                case "mkd":
                    command = new EspecificCommand(new MkdAction(dir));
                    command.Execute(param);
                    break;
                case "cd":
                    CdAction action = new CdAction(dir);
                    command = new EspecificCommand(action);
                    command.Execute(param);
                    dir = action.GetNewDirectory();
                    break;
                case "touch":
                    command = new EspecificCommand(new TouchAction(dir));
                    command.Execute(param);
                    break;
                default:
                    Console.WriteLine("The command does not exists");
                    break;
            }
            return dir;
        }
    }


}


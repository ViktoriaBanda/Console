using System;
using System.IO;

namespace MyConsole;

static class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Ожидаю ввода команды...");
        
        var commandProcessor = new CommandProcessor();

        while (true)
        {
            var commandLine = Console.ReadLine();
            if (commandLine == CommandsNames.EXIT)
                break;

            commandProcessor.ProcessCommand(commandLine);
        }
    }
}

/*static class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Ожидаю ввода команды...");
        WaitForCommand();
    }

    private static void WaitForCommand()
    {
        var currentDirectory = new MyConsole(Directory.GetCurrentDirectory());
        var help = new Help();

        while (true)
        {
            var command = Console.ReadLine();

            else if (CommandsHelper.IdReadTextFile(command))
            {
                var fileName = command?[CommandsLength.READ_TEXT_FILE..];
                currentDirectory.ReadTextFile.PrintText(fileName);
            }
            else if (CommandsHelper.IsCreateDirectory(command))
            {
                var directoryName = command?[CommandsLength.CREATE_DIRECTORY..];
                currentDirectory.MakeDirectory.CreateDirectory(directoryName);
            }
            else if (CommandsHelper.IsCreateFile(command))
            {
                var fileName = command?[CommandsLength.CREATE_FILE..];
                currentDirectory.MakeFile.CreateFile(fileName);
            }           
        }
    }
}*/
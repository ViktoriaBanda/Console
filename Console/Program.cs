using System;

namespace MyConsole;

internal static class Program
{
    private static void Main()
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
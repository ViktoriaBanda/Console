using System;

namespace MyConsole;

class GoToParentDirectoryCommand : ICommand
{
    public void Execute(string argument)
    {
        if (CommandProcessor.CurrentDirectory.Parent == null)
        {
            Console.WriteLine("Достигнута корневая директория. Дальше пути нет");
            CommandProcessor.CurrentDirectory = CommandProcessor.CurrentDirectory;
            return;
        }
            
        CommandProcessor.CurrentDirectory = CommandProcessor.CurrentDirectory.Parent;
        Console.WriteLine(CommandProcessor.CurrentDirectory.FullName);
    }
}
using System;

namespace MyConsole;

class PrintWorkingDirectoryCommand : ICommand
{
    public void Execute(string argument)
    {
        Console.WriteLine(CommandProcessor.CurrentDirectory.FullName);
    }
}
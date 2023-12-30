using System;
using System.IO;

namespace MyConsole;

class CreateDirectoryCommand : ICommand
{
    private PrintLocalStatementCommand _printLocalStatementCommand;

    public CreateDirectoryCommand(PrintLocalStatementCommand printLocalStatementCommand)
    {
        _printLocalStatementCommand = printLocalStatementCommand;
    }

    public void Execute(string argument)
    {
        var directoryName = Path.GetFullPath(argument, CommandProcessor.CurrentDirectory.FullName);

        if (Directory.Exists(directoryName))
        {
            Console.WriteLine("Такая директория уже существует");
            return;
        }

        Directory.CreateDirectory(directoryName);
        _printLocalStatementCommand.Execute(directoryName);
    }
}
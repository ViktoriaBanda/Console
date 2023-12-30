using System;
using System.IO;
using MyConsole;


class CreateFileCommand : ICommand
{
    private PrintLocalStatementCommand _printLocalStatementCommand;

    public CreateFileCommand(PrintLocalStatementCommand printLocalStatementCommand)
    {
        _printLocalStatementCommand = printLocalStatementCommand;
    }
    
    public void Execute(string argument)
    {
        var fileName = Path.GetFullPath(argument, CommandProcessor.CurrentDirectory.FullName);

        if (File.Exists(fileName))
        {
            Console.WriteLine("Файл с таким названием по заданному пути уже существует");
            return;
        }

        try
        {
            var newFile = File.Create(fileName);
            _printLocalStatementCommand.Execute(new FileInfo(fileName).DirectoryName);
            newFile.Close();
        }
        catch (DirectoryNotFoundException exeption)
        {
            Console.WriteLine("Неверно указан путь к файлу\n" + exeption.Message);
        }
    }
}
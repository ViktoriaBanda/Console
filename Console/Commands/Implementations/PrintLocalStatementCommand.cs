using System;

namespace MyConsole;

class PrintLocalStatementCommand : ICommand
{
    public void Execute(string argument)
    {
        var filesInfo = CommandProcessor.CurrentDirectory.GetFileSystemInfos();
        Console.WriteLine("Имя диска\tДата и время последнего изменения\tИмя");
        foreach (var fileInfo in filesInfo)
        {
            Console.WriteLine($"{CommandProcessor.CurrentDirectory.Root}\t" +
                              $"\t{fileInfo.LastAccessTime}\t" +
                              $"\t\t{fileInfo.Name}");
        }
    }
}
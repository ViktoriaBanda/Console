using System;
using System.IO;
using System.Linq;

namespace MyConsole;

class GoToDirectoryCommand : ICommand
{
    public void Execute(string directoryName)
    {
        if (directoryName == null)
        {
            ShowDirectoryMotFoundMessage();
            return;

        }
        
        directoryName = Path.GetFullPath(directoryName, CommandProcessor.CurrentDirectory.FullName);
        var disks = DriveInfo.GetDrives();
        
        if (Directory.Exists(directoryName))
        {
            CommandProcessor.CurrentDirectory = new DirectoryInfo(directoryName);
            Console.WriteLine(CommandProcessor.CurrentDirectory.FullName);
            return;
        }
            
        if (disks.Any(disk => disk.Name == directoryName))
        {
            CommandProcessor.CurrentDirectory = new DirectoryInfo(directoryName);
            Console.WriteLine(CommandProcessor.CurrentDirectory.FullName);
            return;
        }

        ShowDirectoryMotFoundMessage();
    }

    private void ShowDirectoryMotFoundMessage()
    {
        Console.WriteLine("Директория не найдена");
    }
}
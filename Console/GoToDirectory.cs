using System;
using System.IO;

namespace Консоль
{
    public class GoToDirectory
    {
        private MyDirectory _myDirectory;

        public GoToDirectory(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        public void PrintNewDirectory(string directoryName)
        {
            directoryName = Path.GetFullPath(directoryName, _myDirectory.CurrentDirectory.FullName);
            var disks = DriveInfo.GetDrives();
        
            //существует ли директория:
            if (Directory.Exists(directoryName))
            {
                _myDirectory.CurrentDirectory = new DirectoryInfo(directoryName);
                Console.WriteLine(_myDirectory.CurrentDirectory.FullName);
                return;
            }
            
            foreach (var disk in disks)
            {
                if (disk.Name == directoryName)
                {
                    _myDirectory.CurrentDirectory = new DirectoryInfo(directoryName);
                    Console.WriteLine(_myDirectory.CurrentDirectory.FullName);
                    return;
                }
            }

            Console.WriteLine("Директория не найдена");
        }
    }
}

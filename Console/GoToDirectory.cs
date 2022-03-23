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
        
            //существует ли директория:
            if (Directory.Exists(directoryName))
            {
                _myDirectory.CurrentDirectory = new DirectoryInfo(directoryName);
                Console.WriteLine(_myDirectory.CurrentDirectory.FullName);
            }
            else
            {
                Console.WriteLine("Директория не найдена");
            }
        }
    }
}

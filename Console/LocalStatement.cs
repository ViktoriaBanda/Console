using System;
using System.IO;

namespace Консоль
{
    public class LocalStatement
    {
        private MyDirectory _myDirectory;
        private DirectoryInfo _newDirectory;

        public LocalStatement(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        
        public LocalStatement(string newDirectory)
        {
            _newDirectory = new DirectoryInfo(newDirectory);
        }
        
        public void PrintLocalStatement()
        {
            if (_newDirectory != null)
            {
                var allDirectories = _newDirectory.GetFileSystemInfos();
                Console.WriteLine("Имя диска\tДата и время последнего изменения\tИмя");
                for (var i = 0; i < allDirectories.Length; i++)
                {
                    Console.WriteLine($"{_newDirectory.Root}\t" +
                                      $"\t{allDirectories[i].LastAccessTime}\t" +
                                      $"\t\t{allDirectories[i].Name}");
                }
                return;
            }
            
            var array = _myDirectory.CurrentDirectory.GetFileSystemInfos();
            Console.WriteLine("Имя диска\tДата и время последнего изменения\tИмя");
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{_myDirectory.CurrentDirectory.Root}\t" +
                                  $"\t{array[i].LastAccessTime}\t" +
                                  $"\t\t{array[i].Name}");
            }
        }
    }
}
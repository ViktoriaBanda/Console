using System;
using System.IO;

namespace Консоль
{
    public class ReadTextFile
    {
        private MyDirectory _myDirectory;

        public ReadTextFile(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }

        public void PrintText(string fileName)
        {
            var subDirectories = _myDirectory.CurrentDirectory.GetFileSystemInfos();
            var wasFileFound = false;
            foreach (var f in subDirectories)
            {
                if (Path.GetFileNameWithoutExtension(f.FullName) == fileName)
                {
                    wasFileFound = true;
                    if (IsFileText(f))
                    {
                        var text = File.ReadAllText(f.FullName);
                        Console.WriteLine(text);
                        return;
                    }
                }
            }
            if(wasFileFound)
            {
                Console.WriteLine("Файл не является текстовым");
                return;
            }
            
            Console.WriteLine("Файл не найден в текущей директории");
        }

        private bool IsFileText(FileSystemInfo file)
        {
            if (file.Extension == ".txt")
            {
                return true;
            }

            return false;
        }
    }
}
using System;
using System.IO;
using MyConsole;

internal class ReadTextFileCommand : ICommand
    {
        public void Execute(string argument)
        {
            var subDirectories = CommandProcessor.CurrentDirectory.GetFileSystemInfos();
            var wasFileFound = false;
            foreach (var f in subDirectories)
            {
                if (Path.GetFileNameWithoutExtension(f.FullName) == argument)
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
            return file.Extension == ".txt";
        }
    }

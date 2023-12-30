using System;
using System.IO;

namespace MyConsole
{
    public class MakeDirectory
    {
        private readonly MyDirectory _myDirectory;
        //private LocalStatement _localStatement;

        public MakeDirectory(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        
        public void CreateDirectory(string directoryName)
        {
            directoryName = Path.GetFullPath(directoryName, _myDirectory.CurrentDirectory.FullName);
            
            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Такая директория уже существует");
                return;
            }

            Directory.CreateDirectory(directoryName);
            //_localStatement = new LocalStatement(new DirectoryInfo(directoryName).Parent?.FullName);
            //_localStatement.PrintLocalStatement();
        }
    }
}
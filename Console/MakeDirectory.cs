using System;
using System.IO;

namespace Консоль
{
    public class MakeDirectory
    {
        private MyDirectory _myDirectory;
        private LocalStatement _localStatement;

        public MakeDirectory(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        
        public void CreateDirectory(string directoryName)
        {
            //проверяем, существует ли уже такая директория
            directoryName = Path.GetFullPath(directoryName, _myDirectory.CurrentDirectory.FullName);
            
            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Такая директория уже существует");
                return;
            }

            Directory.CreateDirectory(directoryName);
            _localStatement = new LocalStatement(new DirectoryInfo(directoryName).Parent.FullName);
            _localStatement.PrintLocalStatement();
        }
    }
}
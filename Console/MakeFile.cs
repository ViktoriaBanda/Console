using System;
using System.IO;

namespace Консоль
{
    public class MakeFile
    {
        private MyDirectory _myDirectory;
        private LocalStatement _localStatement;
        
        public MakeFile(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        public void CreateFile(string fileName)
        {
            //проверяем, существует ли уже такой файл
            fileName = Path.GetFullPath(fileName, _myDirectory.CurrentDirectory.FullName);
           
            if (File.Exists(fileName))
            {
                Console.WriteLine("Файл с таким названием по заданному пути уже существует");
                return;
            }

            try
            {
                var newFile = File.Create(fileName);
                _localStatement = new LocalStatement(new FileInfo(fileName).DirectoryName);
                _localStatement.PrintLocalStatement();
                newFile.Close();
            }
            catch (DirectoryNotFoundException exeption)
            {
                Console.WriteLine("Неверно указан путь к файлу\n" + exeption.Message);
            }
        }
    }
}
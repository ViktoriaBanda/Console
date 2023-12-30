using System;

namespace MyConsole
{
    public class ChangeDirectory
    {
        private readonly MyDirectory _myDirectory;

        public ChangeDirectory(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        
        public void PrintCurrentDirectory()
        {
            if (_myDirectory.CurrentDirectory.Parent == null)
            {
                Console.WriteLine("Достигнута корневая директория. Дальше пути нет");
                _myDirectory.CurrentDirectory = _myDirectory.CurrentDirectory;
                return;
            }
            
            _myDirectory.CurrentDirectory = _myDirectory.CurrentDirectory.Parent;
            Console.WriteLine(_myDirectory.CurrentDirectory.FullName);
        }
    }
}
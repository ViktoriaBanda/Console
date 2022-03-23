using System;
using System.IO;

namespace Консоль
{
    public class WorkingDirectory
    {
        private MyDirectory _myDirectory;

        public WorkingDirectory(MyDirectory myDirectory)
        {
            _myDirectory = myDirectory;
        }
        public void PrintWorkingDirectory()
        {
            Console.WriteLine(_myDirectory.CurrentDirectory.FullName);
        }
    }
}
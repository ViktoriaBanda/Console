namespace MyConsole
{
    public class MyConsole
    {
       
        public readonly ChangeDirectory ChangedDirectory;
        public readonly ReadTextFile ReadTextFile;
        public readonly MakeDirectory MakeDirectory;
        public readonly MakeFile MakeFile;
        private MyDirectory _currentDirectory;

        public MyConsole(string currentDirectory)
        {
            _currentDirectory = new MyDirectory(currentDirectory);
            
            ChangedDirectory = new ChangeDirectory(_currentDirectory);
            ReadTextFile = new ReadTextFile(_currentDirectory);
            MakeDirectory = new MakeDirectory(_currentDirectory);
            MakeFile = new MakeFile(_currentDirectory);
        }
    }
}
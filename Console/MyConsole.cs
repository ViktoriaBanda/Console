namespace Консоль
{
    public class MyConsole
    {
        public MyDirectory CurrentDirectory;
        public WorkingDirectory workingDirectory;
        public ChangeDirectory changedDirectory;
        public LocalStatement localStatement;
        public GoToDirectory goToDirectory;
        public ReadTextFile readTextFile;
        public MakeDirectory makeDirectory;
        public MakeFile makeFile;

        public MyConsole(string currentDirectory)
        {
            CurrentDirectory = new MyDirectory(currentDirectory);
            workingDirectory = new WorkingDirectory(CurrentDirectory);
            changedDirectory = new ChangeDirectory(CurrentDirectory);
            localStatement = new LocalStatement(CurrentDirectory);
            goToDirectory = new GoToDirectory(CurrentDirectory);
            readTextFile = new ReadTextFile(CurrentDirectory);
            makeDirectory = new MakeDirectory(CurrentDirectory);
            makeFile = new MakeFile(CurrentDirectory);
        }
    }
}
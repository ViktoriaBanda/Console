namespace MyConsole;

interface ICommand
{
    void Execute(string argument);

    void Execute()
    {
        
    }
}


using System;

namespace MyConsole;

class ConsoleClearCommand : ICommand
{
    public void Execute(string argument)
    {
        Console.Clear();
        Console.WriteLine("Ожидаю ввода команды...");
    }
}
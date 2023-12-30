using System;
using System.Collections.Generic;
using System.IO;

namespace MyConsole;

class CommandProcessor
{
    public static DirectoryInfo CurrentDirectory = new(Directory.GetCurrentDirectory());

    private readonly Dictionary<string, ICommand> _commands = new()
    {
        { CommandsNames.GO_TO_DIRECTORY, new GoToDirectoryCommand() },
        { CommandsNames.PRINT_LOCAL_STATEMENT, new PrintLocalStatementCommand() },
        { CommandsNames.PRINT_WORKING_DIRECTORY, new PrintWorkingDirectoryCommand() },
        {CommandsNames.CLEAR, new ConsoleClearCommand()},
        {CommandsNames.HELP, new HelpCommand()}
    };

    public void ProcessCommand(string commandLine)
    {
        var commandName = ExtractCommandName(commandLine);
        var argument = ExtractArgument(commandLine);

        if (HasCommandName(commandName) && _commands.TryGetValue(commandName, out var command))
        {
            command.Execute(argument);
        }
        else
        {
            Console.WriteLine("Неизвестная команда. Чтобы посмотреть список всех команд введите help");
        }
    }

    private string ExtractCommandName(string commandLine)
    {
        return commandLine.GetSubstringBeforeFirstSpace();
    }

    private string ExtractArgument(string commandLine)
    {
        return commandLine.GetSubstringAfterFirstSpace();
    }

    private bool HasCommandName(string command)
    {
        return command != null;
    }
}
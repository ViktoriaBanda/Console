using System;
using System.IO;

namespace Консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ожидаю ввода команды...");
            WaitForCommand();
        }

        private static void WaitForCommand()
        {
            MyConsole currentDirectory = new MyConsole(Directory.GetCurrentDirectory());
            var help = new Help();

            while (true)
            {
                var command = Console.ReadLine();

                if (CommandHelper.GoToDirectory(command))
                {
                    var directoryName = command.Substring(3);
                    currentDirectory.goToDirectory.PrintNewDirectory(directoryName);
                }
                else if (CommandHelper.ReadText(command))
                {
                    var fileName = command.Substring(4);
                    currentDirectory.readTextFile.PrintText(fileName);
                }
                else if (CommandHelper.CreateDirectory(command))
                {
                    var directoryName = command.Substring(6);
                    currentDirectory.makeDirectory.CreateDirectory(directoryName);
                }
                else if (CommandHelper.CreateFile(command))
                {
                    var fileName = command.Substring(7);
                    currentDirectory.makeFile.CreateFile(fileName);
                }

                else
                {
                    switch (command)
                    {
                        case "pwd":
                            currentDirectory.workingDirectory.PrintWorkingDirectory();
                            break;

                        case "cd..":
                            currentDirectory.changedDirectory.PrintCurrentDirectory();
                            break;

                        case "cd ..":
                            currentDirectory.changedDirectory.PrintCurrentDirectory();
                            break;

                        case "ls":
                            currentDirectory.localStatement.PrintLocalStatement();
                            break;

                        case "clear":
                            Console.Clear();
                            Console.WriteLine("Ожидаю ввода команды...");
                            break;

                        case "help":
                            help.PrintInformation();
                            break;

                        case "exit":
                            Console.WriteLine("Приятно было поработать! До свидания!");
                            return;

                        default:
                            Console.WriteLine(
                                "Неизвестная команда. Чтобы посмотреть список всех команд введите help");
                            break;
                    }
                }
            }
        }
    }
}


    
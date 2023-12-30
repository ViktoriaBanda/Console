using System;
using MyConsole;

class HelpCommand : ICommand
{
    public void Execute(string argument)
    {
        Console.WriteLine("pwd \t\t\t- показать текущую директорию\n" +
                          "cd.. или cd .. \t\t- перейти на директорию выше\n" +
                          "cd 'DirectoryName' \t- перейти в указанную директорию\n" +
                          "ls \t\t\t- вывод всех имеющихся в текущей директории файлов и папок\n" +
                          "cat 'FileName' \t\t- вывод содержимого указанного текстового файла (без расширения)\n" +
                          "mkdir 'DirectoryName' \t- создать директорию с указанным именем\n" +
                          "mkfile 'FileName' \t- создать файл с указанным именем\n" +
                          "clear \t\t\t- очистка консоли\n" +
                          "exit \t\t\t- выход\n" +
                          "help \t\t\t- справка по имеющимся командам");
    }
}
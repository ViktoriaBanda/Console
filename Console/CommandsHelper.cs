namespace MyConsole
{
    public static class CommandsHelper
    {
        public static bool IsGoToDirectory(string command)
        {
            return command.Length > 3 && command.Substring(0, 3) == "cd ";
        }

        public static bool IdReadTextFile(string command)
        {
            return command.Length > 4 && command.Substring(0, 4) == "cat ";
        }

        public static bool IsCreateDirectory(string command)
        {
            return command.Length > 6 && command.Substring(0, 6) == "mkdir ";
        }

        public static bool IsCreateFile(string command)
        {
            return command.Length > 7 && command.Substring(0, 7) == "mkfile ";
        }
    }
}
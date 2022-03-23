namespace Консоль
{
    public static class CommandHelper
    {
        public static bool GoToDirectory(string command)
        {
            return command.Length > 3 && command.Substring(0, 3) == "cd ";
        }

        public static bool ReadText(string command)
        {
            return command.Length > 4 && command.Substring(0, 4) == "cat ";
        }

        public static bool CreateDirectory(string command)
        {
            return command.Length > 6 && command.Substring(0, 6) == "mkdir ";
        }

        public static bool CreateFile(string command)
        {
            return command.Length > 7 && command.Substring(0, 7) == "mkfile ";
        }
    }
}
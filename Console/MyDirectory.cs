using System.IO;

namespace MyConsole
{
   public class MyDirectory
   {
       public DirectoryInfo CurrentDirectory;

       public MyDirectory(string currentDirectory)
       {
           CurrentDirectory = new DirectoryInfo(currentDirectory);
       }
   }
}
using System.IO;

namespace Консоль
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
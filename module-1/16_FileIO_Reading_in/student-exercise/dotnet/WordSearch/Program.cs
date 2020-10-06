using System;
using System.IO;

namespace WordSearch
{
   public class Program
    {
        static void Main(string[] args)
        {
            //string myPath = "C:\\Users\\Student\breydongates-c-sharp-material\\module-1\\16_FileIO_Reading_in\\student-exercise\\dotnet";
            //string[] files = Directory.GetFiles(myPath);
            //string filePath = Path.Combine(myPath, "alices_adventures_in_wonderland.txt");
            WordSearchApp app = new WordSearchApp();
            app.Run();
        }
    }
}

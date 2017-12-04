using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            String planet;
            planet = string.Format("Hello {0}", "Mars");
            Console.WriteLine(planet);
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            string[] currentFiles = Directory.GetFiles(path, "*.*");
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
                Console.WriteLine(file.Name);
            }
        }
    }
}

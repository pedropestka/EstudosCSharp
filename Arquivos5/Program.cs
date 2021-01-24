using System;
using System.IO;

namespace Arquivos5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";

            try
            {
                // FORMA 1 (using System.Collections.Generic):
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);


                // relacionar folders/Directories
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //coleçao

                Console.WriteLine("Folders:");

                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }


                // relacionar files
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");

                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //criar uma pasta
                Directory.CreateDirectory(path + @"\newFolderCreated");
                // ou Directory.CreateDirectory(@"C:\temp\myfolder\newFolderCreated");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
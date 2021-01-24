using System;
using System.IO;

namespace Arquivos2b
{
    class Program
    {
        static void Main(string[] args)
        {
            // forma resumida de instanciar o StreamReader

            string path = @"C:\temp\file1.txt";
            StreamReader sr = null;

            try
            {
                //instanciar o obj streamreader utilizando como auxiliar a classe File
                // o OpenText implicitamente instancia o FileStream, e instancia o StreamReader
                sr = File.OpenText(path); 

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.IO;

namespace Arquivos1
{
    class Program
    {
        static void Main(string[] args)
        {

            // arquivo de origem
            string soursePath = @"C:\temp\file1.txt";
            // ou string soursePath = "C:\\temp\\file1.txt";


            // arquivo de destino
            string targetPath = @"C:\temp\file2.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(soursePath);
                fileInfo.CopyTo(targetPath); // cria o file2

                string[] lines = File.ReadAllLines(soursePath); // cria um vetor com as linhas do arquivo

                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurr");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.IO;

namespace Arquivos4
{
    class Program
    {
        static void Main(string[] args)
        {

            string soursePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(soursePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string sl in lines)
                    {
                        sw.WriteLine(sl.ToUpper());
                    }
                }
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


/*
 * AppendText - concatena ao texto exitente - vai acrescentar o texto ao final do arquivo
 * WriteLine
 * ToUpper
 */
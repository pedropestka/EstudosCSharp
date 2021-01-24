using System;
using System.IO;

namespace Arquivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //acesso a um arquivo -->> é necessário instanciar dois objetos

            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            
            try
            {
                //instanciar o filestream associado ao file
                fs = new FileStream(path, FileMode.Open); // abrir file >>> FileMode.Open)

                //instanciar o obj streamreader associado ao filestream
                sr = new StreamReader(fs);

                //lendo apenas a primeira linha
                //string line = sr.ReadLine();
                //Console.WriteLine(line);

                // lendo todas as linhas do arquivo:
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
                if (fs != null) fs.Close();
            }
            Console.ReadLine();
        }
    }
}
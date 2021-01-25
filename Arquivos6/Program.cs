using System;
using System.IO;

namespace Arquivos6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            // caracter de separaçao (Windows: \ e Linux: /)
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            //DirectorySeparatorChar: \


            // separador de path diferentes
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            //PathSeparator:;


            // nome da pasta sem o arquivo
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            //GetDirectoryName: c:\temp\myfolder


            // nome do arquivo com a extensao
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            //GetFileName: file1.txt


            // extensao do arquivo
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            //GetExtension: .txt


            // nome do arquivo sem a extensao
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            //GetFileNameWithoutExtension: file1


            // caminho completo do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            //GetFullPath: c:\temp\myfolder\file1.txt


            // pasta temporaria do sistema
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            //GetTempPath: C: \Users\pedro\AppData\Local\Temp\


            Console.ReadLine();
        }
    }
}



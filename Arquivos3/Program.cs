﻿using System;
using System.IO;

namespace Arquivos3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";

            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
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
 * FileMode.Open
 * using block
 * 
 */

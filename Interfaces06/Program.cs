﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Interfaces06
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
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
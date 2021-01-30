using System;

namespace Generics01
{
    class Program
    {
        static void Main(string[] args)
        {
            // definindo o tipo que quero
            PrintService<string> printService = new PrintService<string>();

            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());

            Console.ReadLine();

        }
    }
}

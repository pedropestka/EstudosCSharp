using Generics03.Entities;
using System;

namespace Generics03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Comparando dois objetos
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };


            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); // compara a referencia de ponteiro de memória do objeto
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());













            // comparando variáveis
            //string a = "Maria";
            //string b = "Alex";
            //string c = "Maria";

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(c.GetHashCode());

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.Equals(c));

            Console.ReadLine();
        }
    }
}

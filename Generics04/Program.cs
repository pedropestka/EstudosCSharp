using System;
using System.Collections.Generic;

namespace Generics04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // HASHSET
            Console.WriteLine("\n**********************************");
            Console.WriteLine(">>HashSet");

            HashSet<string> set = new HashSet<string>();


            set.Add("Tv");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            // conjunto nao tem a noçao de posiçao - nao posso usar for
            // imprimir o conjunto:
            foreach (  string p in set)
            {
                Console.WriteLine(p);
            }





            // SORTEDSET
            Console.WriteLine("\n**********************************");
            Console.WriteLine(">>SortedSet");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 7, 10, 12 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10, };
            ImprimirColecao(a);
            ImprimirColecao(b);


            // uniao
            Console.WriteLine(">>>Uniao");
            SortedSet<int> c = new SortedSet<int>(a); // insere em c os elementos de a
            c.UnionWith(b); // une a c os elementos de b que já nao estejam em c - sem repeticoes
            ImprimirColecao(c);

            // intercessão
            Console.WriteLine(">>>intercessao");
            SortedSet<int> d = new SortedSet<int>(a); // insere em d os elementos de a
            d.IntersectWith(b); // mantem em d apenas os elementos comuns em b
            ImprimirColecao(d);

            // diferenca
            Console.WriteLine(">>>Diferenca");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // elementos de a excluidos os elementos de b
            ImprimirColecao(e);


            Console.ReadLine();
        }

        static void ImprimirColecao<T> (IEnumerable<T> colecao1)
        {
            foreach (T obj in colecao1)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}


/*
**********************************
>> HashSet
True
Tv
Notebook
Tablet

**********************************
>>SortedSet
0 2 4 5 6 7 10 12
5 6 7 8 9 10
>>>Uniao
0 2 4 5 6 7 8 9 10 12
>>>intercessao
5 6 7 10
>>>Diferenca
0 2 4 12
*/
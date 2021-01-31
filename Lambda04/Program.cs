using System;
using System.Collections.Generic;

namespace Lambda04
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> lista = new List<Product>();
			lista.Add(new Product("Tv", 900.00));
			lista.Add(new Product("Mouse", 50.00));
			lista.Add(new Product("Tablet", 350.50));
			lista.Add(new Product("HD Case", 80.90));

			//lista.RemoveAll(p => p.Price >= 100.0); sem a funcao estática Teste produto
			lista.RemoveAll(TesteProduto);

			foreach (Product p in lista)
			{
				Console.WriteLine(p);
			}
			Console.ReadLine();
		}
		public static bool TesteProduto(Product p)
		{
			return p.Price >= 100.0;
		}
	}
}

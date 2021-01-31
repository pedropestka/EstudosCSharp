using System;
using System.Collections.Generic;

namespace Lambda05
{
	class Program
	{
		static void Main(string[] args)
		{
			// aumentar o valore dos dados de uma lista

			List<Product> lista = new List<Product>();
			lista.Add(new Product("Tv", 900.00));
			lista.Add(new Product("Mouse", 50.00));
			lista.Add(new Product("Tablet", 350.50));
			lista.Add(new Product("HD Case", 80.90));

			//expressao lambda
			Action<Product> acao = p => { p.Price += p.Price * 0.1; };

			lista.ForEach(acao);
			// inline
			// lista.ForEach(p => { p.Price += p.Price * 0.1; });

			//lista.ForEach(AlterarDados); 

			foreach (Product p in lista)
			{
				Console.WriteLine(p);
			}
			Console.ReadLine();
		}
		static void AlterarDados(Product p)
		{
			p.Price += p.Price * 0.1;
		}
	}
}
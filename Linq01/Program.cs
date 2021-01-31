using System;
using System.Linq;

namespace Linq01
{
	class Program
	{
		static void Main(string[] args)
		{

			// Especificar o data sourse
			int[] numeros = new int[] { 2, 3, 4, 5 };

			// Definir a consulta
			// Ex. pegar os numeros pares e multiplicar por 10 criando uma nova colecao
			var resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10);

			//ou
			//IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => 10 * x);

			// executar consulta
			foreach (int x in resultado)
			{
				Console.WriteLine(x);
			}

			Console.ReadLine();
		}
	}
}

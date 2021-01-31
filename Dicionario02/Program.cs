using System;
using System.Collections.Generic;
using System.IO;

namespace Dicionario02
{
	class Program
	{
		static void Main(string[] args)
		{

			Dictionary<string, int> votacao = new Dictionary<string, int>();

			Console.Write("Enter file full path: "); //C:\temp\dicionario214.txt 
			string path = Console.ReadLine();

			using (StreamReader sr = File.OpenText(path))
			{
				while (!sr.EndOfStream)
				{
					string[] linhatxt = sr.ReadLine().Split(',');
					string name = linhatxt[0];
					int votos = int.Parse(linhatxt[1]);

					if (votacao.ContainsKey(name))
					{
						votacao[name] += votos;
					}
					else
					{
						votacao[name] = votos;
					}
				}
			}
			foreach (KeyValuePair<string, int> elemento in votacao)
			{
				Console.WriteLine(elemento.Key + ": " + elemento.Value);
			}
			Console.ReadLine();
		}
	}
}
using System;
using System.Collections.Generic;

namespace Docionario01
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> ck = new Dictionary<string, string>();

			ck["user"] = "Maria";
			ck["email"] = "maria@gmail.com";
			ck["phone"] = "99874563";
			ck["phone"] = "89745655";


			Console.WriteLine(ck["email"]);
			ck.Remove("email");
			Console.WriteLine("Phone number: " + ck["phone"]);
			if (ck.ContainsKey("email"))
			{
				Console.WriteLine("Email: " + ck["email"]);
			}
			else
			{
				Console.WriteLine("There is not 'email' key");
			}
			Console.WriteLine("Size: " + ck.Count);
			Console.WriteLine("ALL COOKIES:");
			foreach (KeyValuePair<string, string> item in ck)
			{
				Console.WriteLine(item.Key + ": " + item.Value);



				Console.ReadLine();
			}
		}
	}
}
/*
• dictionary[key] - acessa o elemento pela chave informada
• Add(key, value) - adiciona elemento(exceção em caso de repetição)
• Clear() - esvazia a coleção
• Count - quantidade de elementos
• ContainsKey(key) - verifica se a dada chave existe
• ContainsValue(value) - verifica se o dado valor existe
• Remove(key) - remove um elemento pela chave
*/
using System;

namespace Extensions01
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = new DateTime(2021, 01, 30, 16, 42, 10);
			Console.WriteLine(dt.ElapsedTime());
			Console.ReadLine();
		}
	}
}

/*
Vamos criar um extension method
chamado "ElapsedTime()" no struct
DateTime para apresentar um objeto DateTime na forma de tempo
decorrido, podendo ser em horas (se menor que 24h) ou em dias caso
contrário. Por exemplo:
DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
"4.5 hours"
"3.2 days"
*/
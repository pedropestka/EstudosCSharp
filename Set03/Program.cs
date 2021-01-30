using System;
using System.Collections.Generic;

namespace Set03
{
	class Program
	{
		static void Main(string[] args)
		{

			HashSet<int> a = new HashSet<int>();
			HashSet<int> b = new HashSet<int>();
			HashSet<int> c = new HashSet<int>();
			HashSet<int> totalAlunos = new HashSet<int>();

			Console.Write("How many students for course A? ");
			int na = int.Parse(Console.ReadLine());
			for (int i = 0; i < na; i++)
			{
				a.Add(int.Parse(Console.ReadLine()));
			}

			Console.Write("How many students for course B? ");
			int nb = int.Parse(Console.ReadLine());
			for (int i = 0; i < nb; i++)
			{
				b.Add(int.Parse(Console.ReadLine()));
			}

			Console.Write("How many students for course C? ");
			int nc = int.Parse(Console.ReadLine());
			for (int i = 0; i < nc; i++)
			{
				c.Add(int.Parse(Console.ReadLine()));
			}

			totalAlunos.UnionWith(a);
			totalAlunos.UnionWith(b);
			totalAlunos.UnionWith(c);

			Console.WriteLine("Total students: " + totalAlunos.Count);


			Console.ReadLine();
		}
	}
}

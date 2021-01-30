﻿using Set01.Entities;
using System;
using System.Collections.Generic;

namespace Set01
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.00));
            a.Add(new Product("Notebook", 1200.00));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.00);
            Console.WriteLine(a.Contains(prod)); //true, mas false sem o gethashcode

            // implementando o gethashcode
            Point p = new Point(5, 10);
			Console.WriteLine(b.Contains(p));









            Console.ReadLine();
        }
    }
}

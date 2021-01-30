﻿using System;

namespace Generics01
{
    class PrintService<T> // tipo genérico T
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public  void AddValue(T values)
        {
            if (_count == 10) // lançar excecao
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = values;
            _count++; 
        }

        public T First()
        {
            if (_count == 0) // lançar excecao
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count-1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count-1]);
            }
            Console.WriteLine("]");
        }
    }
}

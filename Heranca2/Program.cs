using Heranca2.Entities;
using System;

namespace Heranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadLine();
        }
    }
}




/*
 * SEALED
 * usado para nao permitir que uma classe ou método seja herdado
 * 
 * 
 * CLASSE SELADA
 * Nota: ainda é possível extender a funcionalidade de uma classe selada usando
 * "extension methods"
 * 
 * Exemplo:
 * 
 * namespace Course {
 * sealed class SavingsAccount {
 * (...)
 * }
 * 
 * 
 * 
 * MÉTODO SELADO
 * Só pode ser aplicado a métodos sobrepostos
 * 
 * Exemplo:
 * 
 * public sealed override void Withdraw(double amount)
 * {
 * base.Withdraw(amount);
 * Balance -= 2.0;
 * }
 * 
 *  
 */
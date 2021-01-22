using Enumeracao1.Entities;
using Enumeracao1.Entities.Enums;
using System;

namespace Enumeracao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment //PendingPayment é uma opção possível
            };

            Console.WriteLine(order);

            // conversar de string para enumeraçao

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // conversao str para tipo enum
            // parametrizacao como se fosse lista

            Console.WriteLine(txt);
            Console.WriteLine(os);

            Console.ReadLine();
        }
    }
}
/*

Conversões
Para o tipo original: use casting
OrderStatus os1 = (OrderStatus)2;
int n1 = (int)OrderStatus.Processing;

###string - enum:

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(txt);

*/

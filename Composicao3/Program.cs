using Composicao3.Entities;
using Composicao3.Entities.Enums;
using System;
using System.Globalization;

namespace Composicao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-Mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            // instanciaçao do cliente
            Client client = new Client(name, email, birth);


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            // instanciaçao da order status - tipo enum
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // instanciaçao Order
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}

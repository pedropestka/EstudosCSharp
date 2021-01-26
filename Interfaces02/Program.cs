using Interfaces02.Entities;
using Interfaces02.Services;
using System;
using System.Globalization;

namespace Interfaces02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService()); // injecao de dependencia

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}


//Inversão de controle:

//Padrão  de desenvolvimento que consiste em retirar da classe a 
//responsabilidade de instanciar suas dependências.




//Injeção de dependência:

//É uma forma de realizar a inversão de controle: um componente externo
//instancia a dependência, que é então injetada no objeto "pai". Pode ser
//implementada de várias formas:
//Construtor
//Objeto de instanciação (builder / factory)
//Container / framework
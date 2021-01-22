using Composicao1.Entities.Enums;
using System.Collections.Generic;

namespace Composicao1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        // Composicao de objetos
        // Forma de realizar a composicao entre duas classes
        public Department Department { get; set; }

        // um trabalhadore tem vários contratos, por isso vamos utilizar uma lista
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();



        // CONSTRUTORES
        public Worker()
        {
        }

        // Não inclui a lista (para-muitos) no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}

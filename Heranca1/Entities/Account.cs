namespace Heranca1.Entities
{
    class Account // saldo
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // Saldo
        // se usarmos o private no set, só poderemos alterar na propria classe
        // para poder modificar nas classes herdadas vamos usar o protected

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) // metodo de saque
        {
            Balance -= amount;
        }

        public void Deposit(double amount) // metodo de deposito
        {
            Balance += amount;
        }
    }
}

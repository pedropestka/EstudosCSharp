namespace Heranca1.Entities
{
    class SavingsAccount : Account // Conta Poupança
    {
        public double InterestRate { get; set; } //tx de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        // atualizaçao do saldo da conta com base na taxa de juros
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}

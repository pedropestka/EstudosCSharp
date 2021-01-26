namespace Interfaces02.Services
{
    class BrazilTaxService : ITaxService // nao é heranca!
    {

        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
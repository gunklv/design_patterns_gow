namespace Facade
{
    public class MortgageSystem
    {
        private readonly Bank _bank = new Bank();
        private readonly Credit _credit = new Credit();

        public bool IsEligible(string customer, int amount)
        {
            var eligible = true;

            if(!_bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}

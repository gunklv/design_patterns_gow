namespace FactoryMethod.Cards
{
    public class CreditCard : BankCard
    {
        public override decimal Limit => decimal.MaxValue;
    }
}

namespace FactoryMethod.Cards
{
    public class MasterCard : BankCard
    {
        public override decimal Limit => 50000.0m;
    }
}

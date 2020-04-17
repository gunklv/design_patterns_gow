namespace FactoryMethod
{
    public interface IBankCardFactory
    {
        BankCard CreateCard(string cardType);
    }
}

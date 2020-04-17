using FactoryMethod.Cards;

namespace FactoryMethod
{
    public class BankCardFactory : IBankCardFactory
    {
        public BankCard CreateCard(string cardType)
        {
            switch (cardType)
            {
                case "master":
                    return new MasterCard();
                case "maestro":
                    return new MaestroCard();
                default:
                    return new CreditCard();
            }
        }
    }
}

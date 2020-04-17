namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var inputCard = "maestro";
            var inputUser = "Viktor";
            var bankCardFactory = new BankCardFactory();

            var card = bankCardFactory.CreateCard(inputCard);

            registration(inputUser, card);
        }

        private static void registration(string user, BankCard card)
        {
            //saving user with bank card into the system
        }
    }
}

namespace ChainOfResponsibility.Dispenser
{
    public class Ft10000Dispenser : DispenseChain
    {
        private DispenseChain _chain;

        public void dispense(Currency currency)
        {
            var remainder = currency.Amount;

            if (currency.Amount >= 10000)
            {
                int num = currency.Amount / 10000;
                remainder = currency.Amount % 10000;

                System.Console.WriteLine($"Dispensing {num} 10000Ft note");
            }
            if(remainder > 0)
            {
                _chain.dispense(new Currency(remainder));
            }
        }

        public DispenseChain setNextChain(DispenseChain nextChain)
        {
            _chain = nextChain;
            return this;
        }
    }
}

namespace ChainOfResponsibility.Dispenser
{
    public class Ft2000Dispenser : DispenseChain
    {
        private DispenseChain _chain;

        public void dispense(Currency currency)
        {
            var remainder = 0;

            if(currency.Amount >= 2000)
            {
                int num = currency.Amount / 2000;
                remainder = currency.Amount % 2000;

                System.Console.WriteLine($"Dispensing {num} 2000Ft note");
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

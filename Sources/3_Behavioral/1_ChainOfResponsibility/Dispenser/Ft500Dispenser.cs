namespace ChainOfResponsibility.Dispenser
{
    public class Ft500Dispenser : DispenseChain
    {
        public void dispense(Currency currency)
        {
            if(currency.Amount >= 500)
            {
                int num = currency.Amount / 500;
                System.Console.WriteLine($"Dispensing {num} 500Ft note");
            }
        }

        public DispenseChain setNextChain(DispenseChain nextChain)
        {
            return null;
        }
    }
}

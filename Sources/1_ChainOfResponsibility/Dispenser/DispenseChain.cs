namespace ChainOfResponsibility.Dispenser
{
    public interface DispenseChain
    {
        DispenseChain setNextChain(DispenseChain nextChain);
        void dispense(Currency currency);
    }
}

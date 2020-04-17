using ChainOfResponsibility.Dispenser;

namespace ChainOfResponsibility
{
    public class ATM
    {
        public DispenseChain Dispenser { get; private set; }

        public ATM()
        {
            var ft20000Dispenser = new Ft20000Dispenser();
            var ft10000Dispenser = new Ft10000Dispenser();
            var ft5000Dispenser = new Ft5000Dispenser();
            var ft2000Dispenser = new Ft2000Dispenser();
            var ft1000Dispenser = new Ft1000Dispenser();
            var ft500Dispenser = new Ft500Dispenser();

            ft20000Dispenser.setNextChain(ft10000Dispenser.setNextChain(ft5000Dispenser.setNextChain(ft2000Dispenser.setNextChain(ft1000Dispenser.setNextChain(ft500Dispenser)))));

            Dispenser = ft20000Dispenser;
        }
    }
}

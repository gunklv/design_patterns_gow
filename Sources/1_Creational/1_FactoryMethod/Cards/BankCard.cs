using System;

namespace FactoryMethod
{
    public abstract class BankCard
    {
        public Guid CardNUmber { get; } = Guid.NewGuid();
        public virtual decimal Limit { get; } = 100000.0m;
    }
}

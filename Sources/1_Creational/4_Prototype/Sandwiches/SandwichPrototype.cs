namespace Prototype.Sandwiches
{
    public abstract class SandwichPrototype
    {
        public virtual SandwichPrototype Clone()
        {
            return (SandwichPrototype)this.MemberwiseClone();
        }
    }
}

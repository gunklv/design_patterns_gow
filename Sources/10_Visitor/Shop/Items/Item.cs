namespace Visitor.Shop
{
    public abstract class Item
    {
        public abstract int Price { get; set; }

        public abstract double Accept(IVisitor visitor);
    }
}

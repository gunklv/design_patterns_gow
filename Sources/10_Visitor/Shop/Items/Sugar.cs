namespace Visitor.Shop
{
    public class Sugar : Item
    {
        public override int Price { get; set; } = 300;

        public override double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}

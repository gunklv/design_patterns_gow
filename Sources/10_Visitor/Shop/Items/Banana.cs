using Visitor.Shop.Items;

namespace Visitor.Shop
{
    public class Banana : Fruit
    {
        public override double Weight { get; set; } = 0.45;
        public override int Price { get; set; } = 500;

        public override double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}

using Visitor.Shop.Items;

namespace Visitor.Shop
{
    public class Cashier : IVisitor
    {
        public int Visit(Item item)
        {
            return item.Price;
        }

        public double Visit(Fruit item)
        {
            return item.Weight * item.Price;
        }
    }
}

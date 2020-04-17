using Visitor.Shop.Items;

namespace Visitor.Shop
{
    public interface IVisitor
    {
        int Visit(Item item);
        double Visit(Fruit item);
    }
}

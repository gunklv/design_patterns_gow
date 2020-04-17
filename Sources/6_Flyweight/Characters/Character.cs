namespace Flyweight.Characters
{
    public abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected string color;

        public abstract void Display(string color = "black");
    }
}

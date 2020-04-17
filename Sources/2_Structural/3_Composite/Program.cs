namespace Composite
{
    class Program
    {
        static void Main()
        {
            var emp1 = new Developer("Géza", "Developer");
            var emp2 = new Developer("Béla", "Developer");
            var emp3 = new Manager("Márk", "Manager");

            emp3.addEmployee(emp1);
            emp3.addEmployee(emp2);
        }
    }
}

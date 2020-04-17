using Interpreter.Expressions;
using System;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            var context = new Context("MCDXLIII");

            var thousandExpression = new ThousandExpression();
            var hundredExpression = new HundredExpression();
            var tenExpression = new TenExpression();
            var oneExpression = new OneExpression();

            thousandExpression.Interpret(context);
            hundredExpression.Interpret(context);
            tenExpression.Interpret(context);
            oneExpression.Interpret(context);

            Console.WriteLine(context.Output);

            Console.ReadLine();
        }
    }
}

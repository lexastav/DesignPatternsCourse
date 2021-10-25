using System;
using H.Interpreter.Pattern;
using H.Interpreter.Pattern.Expressions;

namespace H.Interpreter
{
    //Пока вообще нихрена не понятно по этому паттерну, двигаем дальше
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            int x = 5;
            int y = 24;
            int z = 9;

            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);

            IExpression expression = new SubtructExpression(new AddExpression(
                new NumberExpression("x"), new NumberExpression("y")), new NumberExpression("z"));
            int result = expression.Interpret(context);
            Console.WriteLine($"результат: {result}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Receivers
{
    class Tester
    {
        public void StartTest()
        {
            Console.WriteLine("Тестировщик начинает тестирование");
        }
        public void StopTest()
        {
            Console.WriteLine("ТЕстировщик завершает тестирование");
        }
    }
}

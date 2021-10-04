using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Command.Pattern.Macrocommands.Receivers
{
    class Marketer
    {
        public void StartAdvertize()
        {
            Console.WriteLine("Маркетолог начинает рекламировать продукт");
        }
        public void StopAdvertize()
        {
            Console.WriteLine("Маркетолог прекращает рекламную компанию");
        }
    }
}
